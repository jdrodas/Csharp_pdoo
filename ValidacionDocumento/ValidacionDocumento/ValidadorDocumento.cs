using System;

namespace ValidacionDocumento
{
    class ValidadorDocumento
    {
        //aqui definimos los atributos - el estado
        private Documento elDocumento;
        private string resultadoValidacion;

        //aqui definimos los métodos - los comportamientos 

        //aqui viene el constructor de la clase
        public ValidadorDocumento()
        {
            elDocumento = new Documento();
            resultadoValidacion = "Documento sin validar";
        }

        /// <summary>
        /// Establece el documento que será validado
        /// </summary>
        public Documento ElDocumento
        {
            set
            {
                elDocumento = value;
                EjecutaValidacion();
            }
        }

        /// <summary>
        /// Obtiene el resultado de la validación
        /// </summary>
        public string ResultadoValidacion
        {
            get { return resultadoValidacion; }
        }


        /// <summary>
        /// Realiza la validación del documento de acuerdo a los lineamientos especificados
        /// </summary>
        private void EjecutaValidacion()
        {
            /*
            Para la validación de concordancia, se tiene establecido los siguientes lineamientos

            •	OK - 1. La Tarjeta de Identidad debe tener una longitud de 10 u 11.
            •	OK - 2. El número de la Tarjeta de Identidad de longitud 10 debe ser mayor a 1.000.000.000.
            •	OK - 3. Si la tarjeta de identidad es de longitud 11, los 6 primeros dígitos deben corresponder a la fecha de nacimiento (aammdd).
            •	OK - 4. Si la tarjeta de identidad es de longitud 11, el 10o carácter debe ser 1,3,5,7,9 cuando es una mujer.
            •	OK - 5. Si la tarjeta de identidad es de longitud 11, el 10o carácter debe ser 2,4,6,8,0 cuando es un hombre.

            •	OK - 6. El número de la Cédula de ciudadanía de longitud 10 debe ser mayor a 1.000.000.000.
            •	OK - 7. La Cédula de ciudadanía de una mujer debe tener una longitud de 8 o 10.
            •	OK - 8. El número de la Cédula de ciudadanía de una mujer de longitud 8 debe estar entre 20.000.000 y 69.999.999.
            •	OK - 9. La Cédula de ciudadanía de un hombre debe tener una longitud de 3,4,5,6,7,8 o 10.
            •	OK - 10. El número de la Cédula de ciudadanía de un hombre con longitud de 3,4,5,6,7 u 8 debe estar entre 1 y 19.999.999 o 70.000.000 y 99.999.999.
             */

            //La validacion solo se realiza si los tres parámetros fueron ejecutados
            if (elDocumento.Tipo != "0" && elDocumento.Numero != 0 && elDocumento.Genero != "0")
            {
                //Se necesita la longitud del número del documento
                int longitud = elDocumento.Numero.ToString().Length;

                //se organizan las preguntas de acuerdo a la jerarquía de condiciones

                //Si es tarjeta de identidad -> tipo=T
                if (elDocumento.Tipo == "T")
                {
                    //longitud debe ser 10 u 11 - Lineamiento No. 1
                    if (longitud == 10 || longitud == 11)
                    {
                        //Si la longitud es 10, debe ser mayor a 1.000.000.000 - Lineamiento No. 2
                        if (longitud == 10 && elDocumento.Numero > 1000000000)
                            resultadoValidacion = "Número VÁLIDO para tarjeta de identidad de 10 digitos";
                        else
                            resultadoValidacion = "Número INVÁLIDO para tarjeta de identidad de 10 digitos";

                        //Para los casos cuando la longitud es 11
                        if (longitud == 11)
                        {
                            //validamos que los 6 primeros digitos correspondan a una fecha en formato aammdd - Lineamiento No. 3
                            int fechaYear, fechaMonth, fechaDay;
                            fechaYear = int.Parse(elDocumento.Numero.ToString().Substring(0, 2));
                            fechaMonth = int.Parse(elDocumento.Numero.ToString().Substring(2, 2));
                            fechaDay = int.Parse(elDocumento.Numero.ToString().Substring(4, 2));

                            try
                            {
                                //Aqui intentamos construir una fecha con estos valores
                                DateTime fechaNacimiento = new DateTime(fechaYear, fechaMonth, fechaDay);
                                resultadoValidacion = "Primeros 6 dígitos corresponden a una fecha válida";

                                int digitoParidad = int.Parse(elDocumento.Numero.ToString().Substring(9, 1)); // el décimo digito

                                // Si la tarjeta de identidad es de longitud 11, el 10o carácter debe ser 1,3,5,7,9 cuando es una mujer.
                                if (elDocumento.Genero == "F")
                                {
                                    //Si es mujer, el digitoParidad debe ser impar - Lineamiento No. 4
                                    if (digitoParidad % 2 != 0)
                                        resultadoValidacion += Environment.NewLine + "VÁLIDO - El dígito de paridad corresponde al género femenino: " + digitoParidad;
                                    else
                                        resultadoValidacion = "INVÁLIDO - El dígito de paridad NO corresponde al género femenino: " + digitoParidad + ". Debe ser impar";
                                }
                                else
                                {
                                    //Si es mujer, el digitoParidad debe ser impar - Lineamiento No. 5
                                    if (digitoParidad % 2 == 0)
                                        resultadoValidacion += Environment.NewLine + "VÁLIDO - El dígito de paridad corresponde al género másculino: " + digitoParidad;
                                    else
                                        resultadoValidacion = "INVÁLIDO - El dígito de paridad NO corresponde al género másculino: " + digitoParidad + ". Debe ser par";
                                } // Aqui termina el condicional para validar el género
                            }

                            //La excepción a capturar es argumento fuera del rango, cuando mes y día
                            //no corresponden a valores válidos dentro del rango
                            //Prueba con Febrero 29 en año no bisiesto ;-)
                            catch (ArgumentOutOfRangeException error)
                            {
                                resultadoValidacion = "INVÁLIDO - Los primeros 6 dígitos de la tarjeta de identidad no corresponden a una fecha válida" +
                                    Environment.NewLine + error.Message;
                            }
                        } // Aqui termina el condicional para validar si la longitud es 11

                    }
                    else
                    {
                        resultadoValidacion = "INVÁLIDO - Longitud inválida para tarjeta de identidad";
                    } //Aqui termina el condicional para validar longitud de la tarjeta de identidad es 10 o es 11

                } // Aqui termina el condicional cuando el tipo de documento es T

                //Si es tarjeta de identidad -> tipo=C
                if (elDocumento.Tipo == "C")
                {
                    //Si la longitud es 10, debe ser mayor a 1.000.000.000 - Lineamiento 6, independiente del género
                    if (longitud == 10)
                    {
                        if (elDocumento.Numero > 1000000000)
                            resultadoValidacion = "VALIDO - Número correcto para cédula de ciudadanía de 10 digitos";
                        else
                            resultadoValidacion = "Número inválido para cédula de ciudadanía de 10 digitos";
                    }

                    //Validaciones específicas del género
                    if (elDocumento.Genero == "F")
                    {
                        if (longitud == 8)
                        {
                            // Si la longitud es de 8, para mujer, debe estar en el rango 20.000.000 y 69.999.999 - Lineamiento 7 y 8
                            if (elDocumento.Numero >= 20000000 && elDocumento.Numero <= 699999999)
                            {
                                resultadoValidacion = "VÁLIDO - Número del documento en el rango asignado para el género femenino";
                            }
                            else
                                resultadoValidacion = "INVÁLIDO - Número del documento NO ESTÁ en el rango asignado para el género femenino";
                        }

                        // Las longitudes para documentos del género femenino deben ser de 8 o 10
                        if (longitud != 8 && longitud != 10)
                            resultadoValidacion = "INVÁLIDO - Número del documento NO ESTÁ en el rango asignado para el género femenino";
                    }

                    if (elDocumento.Genero == "M" && (longitud >= 3 && longitud <= 8))
                    {
                        //La Cédula de ciudadanía de un hombre debe tener una longitud de 3,4,5,6,7,8 o 10. - Lineamiento 9
                        if (longitud >= 3 && longitud <= 8)
                        {
                            // Para longitudes entre 3 y 8, debe estar entre los rangos 1 y 19.999.999 y 70.000.000 y 99.999.999
                            if ((longitud >= 3 && longitud <= 8) &&
                                ((elDocumento.Numero >= 1 && elDocumento.Numero <= 19999999) || ((elDocumento.Numero >= 70000000 && elDocumento.Numero <= 99999999))))
                                resultadoValidacion = "VÁLIDO - Número del documento en el rango asignado para el género masculino";
                            else
                                resultadoValidacion = "INVÁLIDO - Número del documento NO ESTÁ en el rango asignado para el género masculino";
                        }
                        else
                            resultadoValidacion = "INVÁLIDO - El número no tiene la longitud requerida para el género másculino";
                    }
                } // Aqui termina condicional de validación por género para cédula
            }
            else
            {
                resultadoValidacion = "No hay datos para realizar la validación";
            } // Aqui termina el condicional de datos ingresados para validación
        }
    }
}

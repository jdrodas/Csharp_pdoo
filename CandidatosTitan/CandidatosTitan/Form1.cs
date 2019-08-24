/*
    
/*
Programa:       CandidatosTitan
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Enunciado al problema:
----------------------

Colonización de Titán – Pacientes en proceso de evolución forzada

Se ha finalizado la primera etapa del proyecto de Colonización de Titán y Rick Janssen exitosamente ha
llegado sin experimentar problemas fisiológicos en su proceso de adaptación a las condiciones climáticas
de la luna de Saturno. Sin embargo, la NASA y el DoD quedaron muy preocupados por las implicaciones
éticas del trabajo científico del Dr. Collingwood, pues de 20 candidatos iniciales, solo uno de ellos finalizó
exitosamente el proceso evolutivo mientras que los otros fallecieron en diferentes y aterradoras
circunstancias.

La nueva administración del proyecto ha decidido tomar una aproximación más rigurosa al proceso de
selección de los candidatos, haciendo una exhaustiva valoración médica en las etapas tempranas; todos
los participantes serán tratados como pacientes con características fisiológicas modificadas.

Inicialmente los pacientes comienzan perteneciendo a la especie “Homo Sapiens” en las mejores
condiciones que los participantes puedan obtener dado su previo entrenamiento militar.

Para cada paciente, se tienen tres características que van a vigilar: Nivel Oxigeno, Capacidad visual y
temperatura corporal. En la siguiente tabla se definen los valores posibles y deseados para cada

característica:
Característica base         Valor mínimo        Valor Máximo        Valor deseado
-------------------         -------------       -------------       --------------
Nivel Oxigeno               5                   20                  7 o menos
Capacidad visual            75                  150                 140 o más
Temperatura Corporal        20                  37                  23 o menos

Un candidato es un paciente que tiene sus características modificadas en los rangos de los valores
deseados. Cuando esto ocurre, se considera que el paciente ha evolucionado a la especie “Homo Titanus”
y es viable para transportar a Titán.

La prueba final consiste en validar la capacidad de vuelo autónomo del candidato. Se define entonces los
siguientes parámetros para esta característica:


Característica adicional    Valor mínimo        Valor Máximo        Valor deseado
-------------------         -------------       -------------       --------------
Vuelo autónomo              5                   30                  15 o más

Se requiere realizar un programa en C# que simule el proceso de selección de 500 candidatos, que
aleatoriamente se le asignarán valores en cada una de las características según el rango presentado.

A nivel de implementación, cree una clase Paciente con los atributos básicos: oxigeno, visual,
temperatura, especie. Inicialice los atributos con los valores aleatorios especificados en la tabla anterior.
Todos los pacientes comienzan con la especie “Homo Sapiens”.

La clase Paciente tiene un método llamado “InfoPersona” que puede ser sobrescrito por clases hijas en la
jerarquía de clase y que devuelve un dato tipo string con el concatenado del nombre y valor de todos los
atributos de la clase.

Cree la clase Candidato que hereda de la clase Paciente e implemente específicamente para ella, los
atributos vuelo y viable.

El atributo vuelo se inicializa como un valor aleatorio según la tabla anterior.
Si los valores de las características base están en los rangos esperados, el valor del atributo especie se
cambia a “Homo Titanus”.

Asigne el atributo “viable” como un valor booleano “true” cuando el atributo especie es “Homo Titanus”
y el vuelo autónomo está en el rango del valor deseado.

En la clase “Candidato” implemente un polimorfismo por sobreescritura para el método “InfoPersona”
en el cual se coloque la información del Paciente más los atributos específicos del candidato.

Cree una clase "ControlSimulación" que se encargue de inicializar el arreglo de 500 Candidatos, calcular 
la viabilidad de los candidatos y obtener y la información solo para los candidatos viables

Cree una Interfaz en Windows Forms que tenga un botón para inicializar la simulación y un textBox multilínea
para visualizar el resultado.
 */

using System;
using System.Windows.Forms;

namespace CandidatosTitan
{
    public partial class Form1 : Form
    {
        private ControlSimulacion miControl;

        public Form1()
        {
            InitializeComponent();

            //aqui inicializamos el atributo tipo ControlSimulacion
            miControl = new ControlSimulacion();
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            //aqui invocamos el método de inicio de la simulación
            miControl.IniciaSimulacion();

            //aqui obtenemos el resultado
            textoInformacion.Text = miControl.ObtieneInfoViables();
        }
    }
}

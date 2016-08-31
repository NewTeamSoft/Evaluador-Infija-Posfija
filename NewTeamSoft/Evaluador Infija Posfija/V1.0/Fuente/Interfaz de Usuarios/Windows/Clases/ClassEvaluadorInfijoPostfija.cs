#region    Librerias de Clase que Utiliza el Evaluador de Expresiones Aritmetica

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion Librerias de Clase que Utiliza el Evaluador de Expresiones Aritmetica

#region    Espacio del Nombre Principal del Evaluador de Expresiones Aritmetica

namespace EvaluadorInfijaPosfija.Clases
{
    #region    Enum Para Determinar el Tipo de Token

    enum Tipo
    {
        Invalido,
        Operador,
        Operando,
        ParentesisA,
        ParentesisB,
        Funcion,
        Constante
    }

    #endregion Enum Para Determinar el Tipo de Token

    #region    Clase Publica del Evaluador de Expresiones Aritmetica

    public class ClassEvaluadorInfijoPostfija
    {

        #region    Propiedad Postfija de Lectura y Escritura

        //Variable para almacenar la exprecion matematica de notacion postfija      
        string postfija;

        /// <summary>
        /// Propiedad que representa la expresion en notacion postfija
        /// </summary>
        public string PostFija
        {
            get { return postfija; }
        }

        #endregion Propiedad Postfija de Lectura y Escritura

        #region    Procedimiento Publico Evaluador Infijo Postfijo

        /// <summary>
        /// Procedimiento publico. Obtiene una expresion aritmetica de notacion infija para luego ser convertida a postfija 
        /// </summary>
        /// <param name="expresionInfija"> Recive la expresion aritmetica infija </param>
        public void evaluador(string expresionInfija)
        {
            //Convierte la Exprecion Infija a Posfija Para Luego Ser Asignada a la Variable Postfija
            postfija = convertirInfijaPostfija(expresionInfija);
        }

        #endregion Procedimiento Publico Evaluador Infijo Postfijo

        #region    Funcion Publica Evalua y Obtiene la Expresion Postfija

        /// <summary>
        /// Funcion Publica. Evalua la expresion postfija
        /// </summary>
        /// <returns> La expresion postfija</returns>
        public double obtenerPostfija()
        {
            return evaluarPostfija(postfija);
        }

        #endregion Funcion Publica Evalua y Obtiene la Expresion Postfija

        #region    Funcion Publica Evalua la Expresion Postfija (Maquina de Pila Abstracta)

        /// <summary>
        /// Funcion publica tipo double. Evalua una expresion postfija y obtiene
        /// el resultado de la operacion (Maquina de pila abstracta).
        /// </summary>
        /// <param name="expresionPostfija"> Recive la expresion postfija </param>
        public double evaluarPostfija(string expresionPostfija)
        {
            // Pila
            Stack<double> pila = new Stack<double>();

            //Lista de Tokens Obtenida de la Expresion Postfia
            string[] tokens = expresionPostfija.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            double operando = 0.0;

            //Ciclo Foreach Para Recorrer Todos los Tokens de la Expresion Postfija
            foreach (string token in tokens)
            {
                //Obtiene el Tipo de Tokens, Si es un Operando o Operador.
                Tipo tipo = obtenerTipoToken(token);

                //Verifica si es un Operador
                if (tipo == Tipo.Operador)
                    EjecutarOperacion(pila, token);

                else if (double.TryParse(token, out operando))
                    pila.Push(operando);
                else throw new Exception("Error formato numerico no valido");
            }

            if (pila.Count != 1)
                throw new Exception("No se ha podido evaluar la expresion");

            return pila.Pop();
        }

        #endregion Funcion Publica Evalua la Expresion Postfija (Maquina de Pila Abstracta)

        #region    Procedimiento Privado Ejecuta la Operacion Aritmetica Con la Notacion Postfija

        /// <summary>
        /// Procedimiento privado. Ejecuta la operacion aritmetica con la notacion postfija 
        /// y obtiene el resultado de la operacion.
        /// </summary>
        /// <param name="pilaOperandos">Pila de operandos</param>
        /// <param name="tipoOperacion">Tipo de operacion aritmetica</param>
        private void EjecutarOperacion(Stack<double> pilaOperandos, string tipoOperacion)
        {
            //Obtiene el Operando de Pila de Operando Para Ser Asignada a la Variable Primer Operando
            double primerOperando = obtenerOperando(pilaOperandos);

            //Selecciona el Tipo de Operacion Para Realizar la Operacion Aritmetica.
            switch (tipoOperacion)
            {
                case "+":
                    pilaOperandos.Push(obtenerOperando(pilaOperandos) + primerOperando);
                    break;
                case "-":
                    pilaOperandos.Push(obtenerOperando(pilaOperandos) - primerOperando);
                    break;
                case "*":
                    pilaOperandos.Push(obtenerOperando(pilaOperandos) * primerOperando);
                    break;
                case "/":
                    if (primerOperando == 0) throw new DivideByZeroException("Error division por cero");
                    pilaOperandos.Push(obtenerOperando(pilaOperandos) / primerOperando);
                    break;
                case "^":
                    pilaOperandos.Push(Math.Pow(obtenerOperando(pilaOperandos), primerOperando));
                    break;
                default:
                    throw new Exception("Error operacion no admitida");
            }
        }

        #endregion Procedimiento Privado Ejecuta la Operacion Aritmetica Con la Notacion Postfija

        #region    Funcion Privada Para Obtener los Operandos

        /// <summary>
        /// Funcion privada de tipo double. Devuelve un operando de la pila de operandos
        /// </summary>
        /// <param name="pilaOperando"> Recive la cantidad de operandos de la pila</param>
        /// <returns> Operando obtenido </returns>
        private double obtenerOperando(Stack<double> pilaOperando)
        {
            //Cuenta la Cantidad de Operandos que Hay en la Pila de Operando
            if (pilaOperando.Count == 0) throw new Exception("Error faltan operandos");

            //Retira de la Pila de el Operando
            return pilaOperando.Pop();
        }

        #endregion Funcion Privada Para Obtener los Operandos

        #region    Funcion Privada Convierte la Expresion Infija a Postfija

        /// <summary>
        /// Funcion privada de tipo string. Convierte una expresion infija a una expresion postfija
        /// </summary>
        /// <param name="expresionInfija">Recive la expresion infija para convertirla a postfija</param>
        /// <returns>Devuelve la expresion en notacion postfija</returns>
        private string convertirInfijaPostfija(string expresionInfija)
        {
            //Instancia de la Clase StringBuilder. Manipula y Modifica una Cadena Sin Crear un Objeto Nuevo
            StringBuilder colaSalida = new StringBuilder();

            //Representa una Colección de Objetos no Genérica de Operadores el Ultimo en Entrar es el Primero en Salir 
            Stack<string> operadores = new Stack<string>();

            //Variable Para Almacenar los Tokens de la Expresion Infija
            string token = string.Empty;

            Tipo tipoToken = Tipo.Invalido;
            Tipo last = Tipo.Invalido;

            //Recorre Cada uno de los Elementos de la Expresion Infija
            for (int i = 0; i < expresionInfija.Length; i++)
            {
                //Almacena en la Variable Token los Tokens de la Expresion Infija
                token = expresionInfija[i].ToString();

                //Verifica si la Cadena Especificada es Null, Está Vacía o Consta Unicamente de Caracteres de Espacio en Blanco
                if (string.IsNullOrWhiteSpace(token)) continue;

                //Obtiene el Tipo de Token. Si es un Operando o un Operador
                tipoToken = obtenerTipoToken(token);

                //
                if (tipoToken == Tipo.Operando)
                {
                    if (last == Tipo.Constante || last == Tipo.ParentesisB)
                        ApilarOperador(colaSalida, operadores, "*");

                    colaSalida.Append(token);
                }
                else if (tipoToken == Tipo.Constante)
                {
                    VerificarMultiplicacionOculta(colaSalida, operadores, last);
                    colaSalida.Append(" " + token + " ");
                }
                else if (tipoToken == Tipo.Operador)
                {
                    if (last == Tipo.Operador && token != "-")
                        throw new Exception("Error falta operando");

                    if ((last == Tipo.Operador && token == "-") ||
                        (last == Tipo.Invalido && token == "-") ||
                        (last == Tipo.ParentesisA && token == "-"))
                    {
                        colaSalida.Append(" -1 ");
                        operadores.Push("*");
                    }
                    else ApilarOperador(colaSalida, operadores, token);
                }
                else if (tipoToken == Tipo.ParentesisA)
                {
                    VerificarMultiplicacionOculta(colaSalida, operadores, last);
                    operadores.Push("(");
                }
                else if (tipoToken == Tipo.ParentesisB) DesapilarParentesis(colaSalida, operadores);
                else
                {
                    int index = expresionInfija.IndexOf('(', i);
                    if (index < 0) throw new Exception("Error en sintaxis");
                    string newtoken = expresionInfija.Substring(i, index - i);
                    i = index - 1;

                    tipoToken = obtenerTipoToken(newtoken);

                    if (tipoToken == Tipo.Funcion)
                    {
                        VerificarMultiplicacionOculta(colaSalida, operadores, last);
                        operadores.Push(newtoken);
                    }
                    else throw new Exception("Error de sintaxis");
                }

                last = tipoToken;
            }

            VaciarOperandos(colaSalida, operadores);
            RemoverEspaciosVacios(colaSalida);

            return colaSalida.ToString();
        }

        #endregion  Funcion Privada Convierte la Expresion Infija a Postfija

        #region     Procedimiento Privado Remueve los Espacios Inncesesarios de la Expresion Postfija.

        /// <summary>
        /// Procedimiento Privado. Elimina espacios en blanco innecesarios
        /// </summary>
        /// <param name="salida"></param>
        private void RemoverEspaciosVacios(StringBuilder salida)
        {
            if (salida[0] == ' ') salida.Remove(0, 1);
            if (salida[salida.Length - 1] == ' ') salida.Remove(salida.Length - 1, 1);

            for (int i = 0; i < salida.Length - 1; i++)
            {
                if (salida[i] == ' ' && salida[i + 1] == ' ')
                    salida.Remove(i, 1);
            }
        }

        #endregion Procedimiento Privado Remueve los Espacios Inncesesarios de la Expresion Postfija

        #region     Procedimiento Privado Verifica la Multiplicacion.
        /// <summary>
        /// Verifica si hay una multiplicacion oculta y la procesa
        /// </summary>
        /// <param name="salida"></param>
        /// <param name="operadores"></param>
        /// <param name="last"></param>
        private void VerificarMultiplicacionOculta(StringBuilder salida, Stack<string> operadores, Tipo last)
        {
            if (last == Tipo.Constante || last == Tipo.Operando || last == Tipo.ParentesisB)
                ApilarOperador(salida, operadores, "*");
        }

        #endregion Procedimiento Privado Verifica la Multiplicacion

        #region Procedimiento Privado Apila todos los Operadores de la Operasion
        /// <summary>
        /// Agrega un aperador a la pila de operandos
        /// </summary>
        private void ApilarOperador(StringBuilder salida, Stack<string> operadores, string token)
        {
            salida.Append(" ");
            if (operadores.Count > 0) DesapilarOperando(token, operadores, salida);
            operadores.Push(token);
        }

        #endregion Procedimiento Privado Apila todos los Operadores de la Operasion

        #region    Procedimiento Privado Salida de los Operadores Hasta Encontrar Parentesis

        /// <summary>
        /// Envia a la salida todos los operadores hasta encontrar un parentesis
        /// </summary>
        /// <param name="salida"></param>
        /// <param name="operadores"></param>
        private void DesapilarParentesis(StringBuilder salida, Stack<string> operadores)
        {
            string sop = operadores.Pop();
            salida.Append(" ");

            while (sop != "(")
            {
                salida.Append(sop + " ");

                if (operadores.Count == 0) throw new Exception("Error falta parentesis de apertura (");

                sop = operadores.Pop();
            }
        }

        #endregion Procedimiento Privado Salida de los Operadores Hasta Encontrar Parentesis

        #region    Procedimiento Privado Envia los Operandos a la Cola de Salida

        /// <summary>
        /// Envia todos los operadores restantes en la pila a la salida
        /// </summary>
        /// <param name="salida"></param>
        /// <param name="operadores"></param>
        private void VaciarOperandos(StringBuilder salida, Stack<string> operadores)
        {
            salida.Append(" ");

            while (operadores.Count > 0)
            {
                string sop = operadores.Pop();

                if (sop == "(")
                    throw new Exception("Error falta parentesis de cierre )");

                salida.Append(sop + " ");
            }
        }

        #endregion Procedimiento Privado Envia los Operandos a la Cola de Salida

        #region    Procedimiento Privado Agrega los Operando de Mayor Presedencia a la Cola de Salida

        /// <summary>
        /// Agrega a la salida todos aquellos operandos de mayor presedencia
        /// </summary>
        private void DesapilarOperando(string operador, Stack<string> operadores, StringBuilder salida)
        {
            int pc = Prioridad(operador);
            string op = operadores.Pop();
            int po = Prioridad(op);

            while (pc <= po)
            {
                salida.Append(op + " ");

                if (operadores.Count == 0) break;

                op = operadores.Pop();
                po = Prioridad(op);
            }

            if (pc > po)
                operadores.Push(op);
        }

        #endregion Procedimiento Privado Agrega los Operando de Mayor Presedencia a la Cola de Salida

        #region    Funcion Privada de Tipo Byte Determina la Mayor Precedencia Entre Operadores

        /// <summary>
        /// Funcion privada de tipo byte. Determina la precedencia de los operadores
        /// </summary>
        /// <param name="operando"> Operadores </param>
        /// <returns> La mayor precedencia entre operadores</returns>
        private byte Prioridad(string operando)
        {
            switch (operando)
            {
                case "(":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                case "%":
                    return 2;
                case "^":
                    return 3;
                default:
                    return 4;
            }
        }

        #endregion Funcion Privada de Tipo Byte Determina la Mayor Precedencia Entre Operadores

        #region    Funcion Privada de Tipo Enum Obtiene el Tipo de Token

        /// <summary>
        /// Funcion privada de tipo enum. Obtiene el tipo de token
        /// </summary>
        /// <param name="tipoToken"> Recive el token espesificado </param>
        /// <returns>El tipo de token</returns>
        private Tipo obtenerTipoToken(string tipoToken)
        {
            //Verifica si el Tokens es un Digito (Operando) y Devuelve el Tipo Operando
            if (char.IsDigit(tipoToken[0]) || tipoToken == ".") return Tipo.Operando;

            //Busca el Tipo de Token
            switch (tipoToken)
            {
                case "/":
                case "*":
                case "-":
                case "+":
                case "^":
                case "%":
                    return Tipo.Operador;
                case "(":
                    return Tipo.ParentesisA;
                case ")":
                    return Tipo.ParentesisB;
                default:
                    return Tipo.Invalido;
            }
        }

        #endregion Funcion Privada de Tipo Enum Obtiene el Tipo de Token

    }

    #endregion Clase Publica del Evaluador de Expresiones Aritmetica
}

#endregion Espacio del Nombre Principal del Evaluador de Expresiones Aritmetica
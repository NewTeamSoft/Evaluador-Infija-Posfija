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
        /// <param name="expresion"> Recive la expresion aritmetica infija </param>
        public void evaluador(string expresion)
        {
            //Convierte la Exprecion Infija a Posfija Para Luego Ser Asignada a la Variable Postfija
            postfija = convertirInfijaPostfija(expresion);
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
                Tipo tipo = GetTipo(token);

                //Verifica si es un Operador
                if (tipo == Tipo.Operador )
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

        /// <summary>
        /// Ejecuta la operacion especificada por el operador
        /// </summary>
        /// <param name="pila">pila de operandos</param>
        /// <param name="operacion">operacion a ejecutar</param>
        private void EjecutarOperacion(Stack<double> pila, string operacion)
        {
            double first = GetOperando(pila);

            switch (operacion)
            {
                case "+":
                    pila.Push(GetOperando(pila) + first);
                    break;
                case "-":
                    pila.Push(GetOperando(pila) - first);
                    break;
                case "*":
                    pila.Push(GetOperando(pila) * first);
                    break;
                case "/":
                    if (first == 0) throw new DivideByZeroException("Error division por cero");
                    pila.Push(GetOperando(pila) / first);
                    break;
                case "^":
                    pila.Push(Math.Pow(GetOperando(pila), first));
                    break;
                default:
                    throw new Exception("Error operacion no admitida");
            }
        }

        /// <summary>
        /// Devuelve un operando de la pila
        /// </summary>
        private double GetOperando(Stack<double> pila)
        {
            if (pila.Count == 0) throw new Exception("Error faltan operandos");
            return pila.Pop();
        }

        /// <summary>
        /// Convierte una expresion infija en una expresion postfija
        /// </summary>
        /// <param name="expresion">expresion matamatica valida que se desea convertir</param>
        /// <returns>Devuelve la expresion en notacion postfija.</returns>
        private string convertirInfijaPostfija(string expresion)
        {
            expresion = expresion.ToLower();
            StringBuilder salida = new StringBuilder();
            Stack<string> operadores = new Stack<string>();
            string token = string.Empty;
            Tipo tipo = Tipo.Invalido;
            Tipo last = Tipo.Invalido;

            for (int i = 0; i < expresion.Length; i++)
            {
                token = expresion[i].ToString();

                if (string.IsNullOrWhiteSpace(token)) continue;

                ////////////////////if (i + 1 < expresion.Length && expresion[i] == 'p' && expresion[i + 1] == 'i')
                ////////////////////{
                ////////////////////    token = "pi";
                ////////////////////    i++;
                ////////////////////}

                tipo = GetTipo(token);

                if (tipo == Tipo.Operando)
                {
                    if (last == Tipo.Constante || last == Tipo.ParentesisB)
                        ApilarOperador(salida, operadores, "*");

                    salida.Append(token);
                }
                else if (tipo == Tipo.Constante)
                {
                    VerificarMultiplicacionOculta(salida, operadores, last);
                    salida.Append(" " + token + " ");
                }
                else if (tipo == Tipo.Operador)
                {
                    if (last == Tipo.Operador && token != "-")
                        throw new Exception("Error falta operando");

                    if ((last == Tipo.Operador && token == "-") ||
                        (last == Tipo.Invalido && token == "-") ||
                        (last == Tipo.ParentesisA && token == "-"))
                    {
                        salida.Append(" -1 ");
                        operadores.Push("*");
                    }
                    else ApilarOperador(salida, operadores, token);
                }
                else if (tipo == Tipo.ParentesisA)
                {
                    VerificarMultiplicacionOculta(salida, operadores, last);
                    operadores.Push("(");
                }
                else if (tipo == Tipo.ParentesisB) DesapilarParentesis(salida, operadores);
                else
                {
                    int index = expresion.IndexOf('(', i);
                    if (index < 0) throw new Exception("Error en sintaxis");
                    string newtoken = expresion.Substring(i, index - i);
                    i = index - 1;

                    tipo = GetTipo(newtoken);

                    if (tipo == Tipo.Funcion)
                    {
                        VerificarMultiplicacionOculta(salida, operadores, last);
                        operadores.Push(newtoken);
                    }
                    else throw new Exception("Error de sintaxis");
                }

                last = tipo;
            }

            VaciarOperandos(salida, operadores);
            RemoverEspaciosVacios(salida);

            return salida.ToString();
        }

        /// <summary>
        /// Elimina espacios en blanco innecesarios
        /// </summary>
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

        /// <summary>
        /// Verifica si hay una multiplicacion oculta y la procesa
        /// </summary>
        private void VerificarMultiplicacionOculta(StringBuilder salida, Stack<string> operadores, Tipo last)
        {
            if (last == Tipo.Constante || last == Tipo.Operando || last == Tipo.ParentesisB)
                ApilarOperador(salida, operadores, "*");
        }

        /// <summary>
        /// Agrega un aperador a la pila de operandos
        /// </summary>
        private void ApilarOperador(StringBuilder salida, Stack<string> operadores, string token)
        {
            salida.Append(" ");
            if (operadores.Count > 0) DesapilarOperando(token, operadores, salida);
            operadores.Push(token);
        }

        /// <summary>
        /// Envia a la salida todos los operadores hasta encontrar un parentesis
        /// </summary>
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

        /// <summary>
        /// Envia todos los operadores restantes en la pila a la salida
        /// </summary>
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

        /// <summary>
        /// Determina la prioridad de un operando
        /// </summary>
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

        /// <summary>
        /// Devuelve el tipo que define a un token
        /// </summary>
        private Tipo GetTipo(string token)
        {
            if (char.IsDigit(token[0]) || token == ".") return Tipo.Operando;

            switch (token)
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
    }

    #endregion Clase Publica del Evaluador de Expresiones Aritmetica
}

#endregion Espacio del Nombre Principal del Evaluador de Expresiones Aritmetica
using System;
using System.Collections;


namespace LinearAlgebra

{
    public class MathVector : IMathVector
    {
        private double[] elements;

        public enum Operations
        {
            plus,
            multiply,
            divide,
            distance
        }

        public MathVector()
        {
            elements = new double[0];
        }

        public MathVector(int lenght)
        {
            elements = new double[lenght];
            for (int i = 0; i < lenght; i++)
            {
                elements[i] = 0;
            }
        }

        public MathVector(MathVector A)
        {
            elements = new double[A.Dimensions];
            for (int i = 0; i < A.Dimensions; i++)
            {
                elements[i] = A.elements[i];
            }
        }

        public MathVector(double[] NewElements)
        {
            for (int i = 0; i < NewElements.Length; i++)
            {
                elements[i] = NewElements[i];
            }
        }

        public int Dimensions
        {
            get
            {
                return elements.Length;
            }
        }

        public double this[int i]
        {
            get
            {
                ThrowingLenghtException(i);
                return elements[i];
            }
            set
            {
                ThrowingLenghtException(i);
                elements[i] = value;
            }
        }


        //проверяет равенство длин, выбрасывает исключение, если что-то не так
        public void ThrowingLenghtException(int elemnum)
        {
            if (elemnum < 0 || elemnum >= Dimensions)
                throw new InvalidOperationException("Wrong number of element");
        }

        public void PutBack(double num)
        {
            Array.Resize<double>(ref elements, Dimensions + 1);
            elements[Dimensions - 1] = num;
        }

        public double Length
        {
            get
            {
                double result_lenght = 0;
                for (int i = 0; i < Dimensions; i++)
                {
                    result_lenght += this[i] * this[i];
                }
                return Math.Sqrt(result_lenght);
            }
        }

        public IMathVector SumNumber(double number)
        {
            MathVector NewVector = new MathVector(this);
            for (int i = 0; i < Dimensions; i++)
            {
                NewVector[i] += number;
            }
            return NewVector;
        }

        public IMathVector MultiplyNumber(double number)
        {
            MathVector NewVector = new MathVector(this);
            for (int i = 0; i < Dimensions; i++)
            {
                NewVector[i] *= number;
            }
            return NewVector;
        }

        public IMathVector Sum(IMathVector vector)
        {
            MathVector newvector = DoVectorOperations(vector, Operations.plus);
            return newvector;
        }

        public IMathVector Multiply(IMathVector vector)
        {
            MathVector newvector = DoVectorOperations(vector, Operations.multiply);
            return newvector;
        }

        public IMathVector Divide(IMathVector vector)
        {
            MathVector newvector = DoVectorOperations(vector, Operations.divide);
            return newvector;
        }

        public double ScalarMultiply(IMathVector vector)
        {
            double result = 0;
            result = DoNumberOperations(vector, Operations.multiply);
            return result;
        }

        public double CalcDistance(IMathVector vector)
        {
            double result = 0;
            result = DoNumberOperations(vector, Operations.distance);
            result = Math.Sqrt(result);
            return result;
        }

        //обработка операций с 2 векторами, в результате которых возвращается вектор
        public MathVector DoVectorOperations(IMathVector vector, Operations operation)
        {
            MathVector newvector = null;
            if (AreEqvivalent(vector))
            {
                newvector = new MathVector(this);
                for (int i = 0; i < Dimensions; i++)
                {
                    newvector[i] = DoOperation(this[i], vector[i], operation);
                }
            }
            else
                this.UnequivalentExeptionThrow();
            return newvector;
        }

        //обработка операций с 2 векторами, в результате которых возвращается скаляр
        public double DoNumberOperations(IMathVector vector, Operations operation)
        {
            double result = 0;
            if (AreEqvivalent(vector))
            {
                for (int i = 0; i < Dimensions; i++)
                {
                    result += DoOperation(vector[i], this[i], Operations.multiply);
                }
            }
            else
                this.UnequivalentExeptionThrow();
            return result;
        }

        //обработка каждой отедльной операции из двух функций выше
        public double DoOperation(double num1, double num2, Operations operation)
        {
            double result = 0;
            switch (operation)
            {
                case Operations.plus:
                    result = num1 + num2;
                    break;
                case Operations.multiply:
                    result = num1 * num2;
                    break;
                case Operations.divide:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }
                    break;
                case Operations.distance:
                    result = Math.Pow((num1 - num2), 2);
                    break;
            }
            return result;
        }

        //вспомогательный метод, проверяет равенство длин двух векторов
        public bool AreEqvivalent(IMathVector vector)
        {
            return Dimensions == vector.Dimensions;
        }

        public void ConsoleWrite()
        {
            for (int i = 0; i < Dimensions; i++)
                Console.WriteLine(this[i]);
        }

        //выбрасывает исключение при операции с неравными векторами
        public void UnequivalentExeptionThrow()
        {
            throw new InvalidOperationException();
        }

        //объединение векторов - в результате сложения возвращается вектор, состоящий из чисел двух векторов
        public MathVector Unite(MathVector vector)
        {
            MathVector newvector = new MathVector(this);
            Array.Resize<double>(ref newvector.elements, Dimensions + vector.Dimensions);
            for (int i = Dimensions - 1; i < vector.Dimensions; i++)
            {
                newvector[i] = vector[i - Dimensions];
            }
            return newvector;
        }


        /*
        + - покомпонентное сложение с числом или другим вектором
        - - покомпонентное вычитание с числом или другим вектором
        * - покомпонентное умножение с числом или другим вектором
        / - покомпонентное деление с числом или другим вектором
        % - скалярное умножение двух векторов*/

        public static IMathVector operator +(MathVector vector1, MathVector vector2)
        {
            return vector1.Sum(vector2);
        }

        public static IMathVector operator +(MathVector vector, double number)
        {
            return vector.SumNumber(number);
        }

        public static IMathVector operator -(MathVector vector1, MathVector vector2)
        {
            return vector1.Sum(vector2.MultiplyNumber(-1));
        }

        public static IMathVector operator -(MathVector vector, double number)
        {
            return vector.SumNumber((-1) * number);
        }

        public static IMathVector operator *(MathVector vector1, MathVector vector2)
        {
            return vector1.Multiply(vector2);
        }

        public static IMathVector operator *(MathVector vector, double number)
        {
            return vector.MultiplyNumber(number);
        }

        public static IMathVector operator /(MathVector vector1, MathVector vector2)
        {
            return vector1.Divide(vector2);
        }

        public static IMathVector operator /(MathVector vector, double number)
        {
            return vector.MultiplyNumber(1 / number);
        }

        public static double operator %(MathVector vector1, MathVector vector2)
        {
            return vector1.ScalarMultiply(vector2);
        }

        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}
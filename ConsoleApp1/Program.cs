using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumberOne, NumberTwo, Operation, StrTemp1, StrTemp2, StrTemp3;
            bool LogicExit = false;
            int IntTemp = 0, IntTemp2=0;
            Subtraction NewSub;
            Addition NewAdd;
            Multiplication NewMultiplication;
            while (!LogicExit)
            {
                Console.WriteLine("Введите перое число");
                NumberOne = Console.ReadLine();
                Console.WriteLine("Введите второе число");
                NumberTwo = Console.ReadLine();
                Console.WriteLine("Введите номер операции: 1 - Сложение, 2 - Вычитание, 3 - умножение, 4 - деление");
                Operation = Console.ReadLine();
                while (Operation[0] > 52 || Operation[0] < 48)
                {
                    Console.WriteLine("Операция не распознана. Повторите ввод.");
                    Console.WriteLine("Введите номер операции: 1 - Сложение, 2 - Вычитание, 3 - умножение, 4 - деление");
                    Operation = Console.ReadLine();
                }
                if (Operation[0] == 49)
                {
                    StrTemp1 = ""; StrTemp2 = "      ";
                    NewAdd = new Addition(NumberOne, NumberTwo);
                    if (!NewAdd.Calculate())
                    {
                        Console.WriteLine("Ошибка. Неверно введены исходные данные. Повторите ввод данных.");
                        Console.ReadKey();
                        continue;
                    }
                    StrTemp1 += "    + ";
                    foreach (double y in NewAdd.StageAdd[0].NumberOne)
                    {
                        if (y == 0.5)
                        {
                            StrTemp1 += ",";
                            continue;
                        }
                        StrTemp1 += y.ToString();
                    }
                    Console.WriteLine(StrTemp1);
                    StrTemp1 = "      ";
                    foreach (double y in NewAdd.StageAdd[0].NumberTwo)
                    {
                        if (y == 0.5)
                        {
                            StrTemp2 += ",";
                            StrTemp1 += "-";
                            continue;
                        }
                        StrTemp2 += y.ToString();
                        StrTemp1 += "-";
                    }
                    Console.WriteLine(StrTemp2);
                    Console.WriteLine(StrTemp1);
                    if (NewAdd.StageAdd[0].AnswerNegative)
                    {
                        StrTemp1 = "     -";
                    }
                    else
                    {
                        StrTemp1 = "      ";
                    }

                    foreach (double y in NewAdd.StageAdd[0].Answer)
                    {
                        if (y == 0.5)
                        {
                            StrTemp1 += ",";
                            continue;
                        }
                        StrTemp1 += y.ToString();
                    }
                    Console.WriteLine(StrTemp1);
                    Console.ReadKey();
                    Console.WriteLine("Выйти из программы? 0 - продолжить работу, 1 - выход из программы");
                    Operation = Console.ReadLine();
                    while (Operation[0] > 49 || Operation[0] < 48)
                    {
                        Console.WriteLine("Команда не распознана. Повторите ввод.");
                        Console.WriteLine("Выйти из программы? 0 - продолжить работу, 1 - выход из программы");
                        Operation = Console.ReadLine();
                    }
                    if (Operation[0] == 49)
                    {
                        LogicExit = true;
                    }
                    continue;
                }
                if (Operation[0] == 50)
                {
                    StrTemp1 = ""; StrTemp2 = "      ";
                    NewSub = new Subtraction(NumberOne, NumberTwo);
                    if (!NewSub.Calculate())
                    {
                        Console.WriteLine("Ошибка. Неверно введены исходные данные. Повторите ввод данных.");
                        Console.ReadKey();
                        continue;
                    }
                    StrTemp1 += "    - ";
                    foreach (double y in NewSub.StageSubtraction[0].NumberOne)
                    {
                        if (y == 0.5)
                        {
                            StrTemp1 += ",";
                            continue;
                        }
                        StrTemp1 += y.ToString();
                    }
                    Console.WriteLine(StrTemp1);
                    StrTemp1 = "      ";
                    foreach (double y in NewSub.StageSubtraction[0].NumberTwo)
                    {
                        if (y == 0.5)
                        {
                            StrTemp2 += ",";
                            StrTemp1 += "-";
                            continue;
                        }
                        StrTemp2 += y.ToString();
                        StrTemp1 += "-";
                    }
                    Console.WriteLine(StrTemp2);
                    Console.WriteLine(StrTemp1);
                    if (NewSub.StageSubtraction[0].AnswerNegative)
                    {
                        StrTemp1 = "     -";
                    }
                    else
                    {
                        StrTemp1 = "      ";
                    }

                    foreach (double y in NewSub.StageSubtraction[0].Answer)
                    {
                        if (y == 0.5)
                        {
                            StrTemp1 += ",";
                            continue;
                        }
                        StrTemp1 += y.ToString();
                    }
                    Console.WriteLine(StrTemp1);
                    Console.ReadKey();
                    Console.WriteLine("Выйти из программы? 0 - продолжить работу, 1 - выход из программы");
                    Operation = Console.ReadLine();
                    while (Operation[0] > 49 || Operation[0] < 48)
                    {
                        Console.WriteLine("Команда не распознана. Повторите ввод.");
                        Console.WriteLine("Выйти из программы? 0 - продолжить работу, 1 - выход из программы");
                        Operation = Console.ReadLine();
                    }
                    if (Operation[0] == 49)
                    {
                        LogicExit = true;
                    }
                    continue;
                }
                if (Operation[0] == 51)
                {
                    StrTemp1 = ""; 
                    NewMultiplication = new Multiplication(NumberOne, NumberTwo);
                    if (!NewMultiplication.Calculate())
                    {
                        Console.WriteLine("Ошибка. Неверно введены исходные данные. Повторите ввод данных.");
                        Console.ReadKey();
                        continue;
                    }
                    StrTemp1 += "             X ";
                    StrTemp3 = "               ";
                    foreach (double y in NewMultiplication.StageMultiplication[0].NumberOne)
                    {
                        if (y == 0.5)
                        {
                            StrTemp1 += ",";
                            StrTemp3 += "-";
                            continue;
                        }
                        StrTemp3 += "-";
                        StrTemp1 += y.ToString();
                    }
                    Console.WriteLine(StrTemp1);
                    StrTemp1 = "               ";
                    StrTemp2 = "               ";
                    IntTemp = NewMultiplication.StageMultiplication[0].NumberOne.Length - NewMultiplication.StageMultiplication[0].NumberTwo.Length;
                    for (int i =0;i < IntTemp; i++)
                    {
                        StrTemp2 += " ";
                    }
                    foreach (double y in NewMultiplication.StageMultiplication[0].NumberTwo)
                    {
                        if (y == 0.5)
                        {
                            StrTemp2 += ",";
                            continue;
                        }
                        StrTemp2 += y.ToString();
                    }
                    Console.WriteLine(StrTemp2);
                    Console.WriteLine(StrTemp3);
                    for (int i= 0; i < NewMultiplication.StageMultiplication.Count - 1; i++)
                    {
                        StrTemp1 = "";
                        IntTemp = 15 - i;
                        for (int i1=0; i1 < IntTemp; i1++)
                        {
                            StrTemp1 += " ";
                        }
                        foreach (double y in NewMultiplication.StageMultiplication[i].Answer)
                        {
                            if (y == 0.5)
                            {
                                StrTemp1 += ",";
                                continue;
                            }
                            StrTemp1 += y.ToString();
                        }
                        Console.WriteLine(StrTemp1);
                    }
                    StrTemp1 = "";
                    for (int i1 = 0; i1 < IntTemp; i1++)
                    {
                        StrTemp1 += " ";
                    }
                    for (int i1 = 0; i1 < 15-IntTemp;i1++)
                    {
                        StrTemp1 += "-";
                    }
                    for (int i1 = 0; i1 < NewMultiplication.StageMultiplication[0].NumberOne.Length; i1++)
                    {
                        StrTemp1 += "-";
                    }
                    Console.WriteLine(StrTemp1);
                    IntTemp2 = NewMultiplication.StageMultiplication.Count-1;
                    IntTemp = 15 - (NewMultiplication.StageMultiplication[IntTemp2].Answer.Length- NewMultiplication.StageMultiplication[0].NumberOne.Length);
                    StrTemp1 = "";
                    for (int i1 = 0; i1 < IntTemp; i1++)
                    {
                        StrTemp1 += " ";
                    }
                    foreach (double y in NewMultiplication.StageMultiplication[IntTemp2].Answer)
                    {
                        if (y == 0.5)
                        {
                            StrTemp1 += ",";
                            continue;
                        }
                        StrTemp1 += y.ToString();
                    }
                    Console.WriteLine(StrTemp1);
                    /*
                    if (NewMultiplication.StageMultiplication[0].AnswerNegative)
                    {
                        StrTemp1 = "     -";
                    }
                    else
                    {
                        StrTemp1 = "      ";
                    }

                    foreach (double y in NewAdd.StageAdd[0].Answer)
                    {
                        if (y == 0.5)
                        {
                            StrTemp1 += ",";
                            continue;
                        }
                        StrTemp1 += y.ToString();
                    }
                    Console.WriteLine(StrTemp1);*/
                    Console.ReadKey();
                    Console.WriteLine("Выйти из программы? 0 - продолжить работу, 1 - выход из программы");
                    Operation = Console.ReadLine();
                    while (Operation[0] > 49 || Operation[0] < 48)
                    {
                        Console.WriteLine("Команда не распознана. Повторите ввод.");
                        Console.WriteLine("Выйти из программы? 0 - продолжить работу, 1 - выход из программы");
                        Operation = Console.ReadLine();
                    }
                    if (Operation[0] == 49)
                    {
                        LogicExit = true;
                    }
                    continue;
                }
            }
        }

        class Division
        {
            public string Dividend;
            public string Divisor;
            public List<Stage> StageDiv = new List<Stage>();
            public Division(string s1, string s2) { Dividend = s1; Divisor = s2; }
            public bool Calculate()
            {
                int DividendQua = 0;
                int DivisorQua = 0;
                if (!Serviсe.CheckNumber(Dividend, Divisor))
                {
                    return false;
                }
                return false;
            }

        }

        class Multiplication
        {
            Addition Add;
            bool Logic = false;
            int TempInt, memory = 0, counter = 0;
            int LogicSw = 0, LogicSw2 = 0;
            public string MultiplierOne;
            public string MultiplierTwo;
            public double[] MultiplierOneM; public double[] MultiplierOneMtemp;
            public double[] MultiplierTwoM; public double[] MultiplierTwoMtemp;
            public List<Stage> StageMultiplication = new List<Stage>();
            public Multiplication(string s1, string s2) { MultiplierOne = s1; MultiplierTwo = s2; }
            public Multiplication(double[] s1, double[] s2) { MultiplierOneM = new double[s1.Length]; MultiplierTwoM = new double[s2.Length]; s1.CopyTo(MultiplierOneM, 0); s2.CopyTo(MultiplierTwoM, 0); Logic = true; }
            public bool Calculate()
            {
                Stage Stage1;
                bool MultiplierOneNegative = false; bool MultiplierTwoNegative = false;
                int MultiplierOneQua = 0; int MultiplierOneQuaBefComma = 0; int MultiplierOneQuaAftComma = 0;
                int MultiplierTwoQua = 0; int MultiplierTwoQuaBefComma = 0; int MultiplierTwoQuaAftComma = 0;
                int MaxBefComma = 0; int MaxAftComma = 0;
                int index = 0;
                if (!Logic)
                {
                    if (!Serviсe.CheckNumber(MultiplierOne, MultiplierTwo))
                    {
                        return false;
                    }
                    MultiplierOneQua = Serviсe.StringNumberQua(MultiplierOne);
                    MultiplierTwoQua = Serviсe.StringNumberQua(MultiplierTwo);
                    MultiplierOneM = new double[MultiplierOneQua];
                    MultiplierTwoM = new double[MultiplierTwoQua];
                    Serviсe.StringToMass(MultiplierOne, MultiplierOneM, MultiplierOneQua, MultiplierOneNegative);
                    Serviсe.StringToMass(MultiplierTwo, MultiplierTwoM, MultiplierTwoQua, MultiplierTwoNegative);
                }
                MultiplierOneQuaBefComma = Serviсe.NumberQuaBeforeComma(MultiplierOneM); MultiplierOneQuaAftComma = Serviсe.NumberQuaAfterComma(MultiplierOneM);
                MultiplierTwoQuaBefComma = Serviсe.NumberQuaBeforeComma(MultiplierTwoM); MultiplierTwoQuaAftComma = Serviсe.NumberQuaAfterComma(MultiplierTwoM);
                if (Logic)
                {
                    MultiplierOneQua = MultiplierOneQuaBefComma + MultiplierOneQuaAftComma;
                    if (MultiplierOneQuaAftComma > 0)
                    {
                        MultiplierOneQua++;
                    }
                    MultiplierTwoQua = MultiplierTwoQuaBefComma + MultiplierTwoQuaAftComma;
                    if (MultiplierTwoQuaAftComma > 0)
                    {
                        MultiplierTwoQua++;
                    }
                }
                MaxBefComma = Serviсe.MaxNumber(MultiplierOneQuaBefComma, MultiplierTwoQuaBefComma);
                MaxAftComma = Serviсe.MaxNumber(MultiplierOneQuaAftComma, MultiplierTwoQuaAftComma);
                index = MaxAftComma + MaxBefComma;
                if (MultiplierTwoQua > MultiplierOneQua)
                {
                    MultiplierOneMtemp = new double[MultiplierTwoQua];
                    MultiplierTwoMtemp = new double[MultiplierOneQua];
                    MultiplierOneM.CopyTo(MultiplierTwoMtemp, 0);
                    MultiplierTwoM.CopyTo(MultiplierOneMtemp, 0);
                    MultiplierOneM = MultiplierOneMtemp;
                    MultiplierTwoM = MultiplierTwoMtemp;
                    TempInt = MultiplierOneQua;
                    MultiplierOneQua = MultiplierTwoQua;
                    MultiplierTwoQua = TempInt;
                }
                for (int i = MultiplierTwoM.Length - 1; i >= 0; i--)
                {
                    memory = 0;
                    Stage1 = new Stage(MultiplierOneQua, MultiplierTwoQua, MultiplierOneQua);
                    if (MultiplierTwoM[i] == 0.5)
                    {
                        continue;
                    }
                    for (int u = MultiplierOneM.Length - 1, y = MultiplierOneM.Length - 1; u >= 0; u--)
                    {
                        if (MultiplierOneM[u] == 0.5)
                        {
                            continue;
                        }
                        if (MultiplierTwoM[i] != 0 || MultiplierOneM[u] != 0)
                        {
                            TempInt = (int)(MultiplierTwoM[i] * MultiplierOneM[u] + memory);
                            memory = 0;
                        }
                        else
                        {
                            TempInt = 0;
                            memory = 0;
                        }

                        if (TempInt > 9)
                        {
                            memory = TempInt / 10;
                            Stage1.Answer[y] = TempInt % 10;
                            if (y == 0 && u == 0)
                            {
                                MultiplierOneMtemp = new double[MultiplierOneQua + 1];
                                Stage1.Answer.CopyTo(MultiplierOneMtemp, 1);
                                MultiplierOneMtemp[0] = TempInt / 10;
                                Stage1.Answer = MultiplierOneMtemp;
                                break;
                            }
                            y--;
                            continue;
                        }
                        Stage1.Answer[y] = TempInt;
                        y--;
                    }
                    StageMultiplication.Add(Stage1);
                }
                if (StageMultiplication.Count > 1)
                {
                    TempInt = StageMultiplication.Count - 1;
                    counter = TempInt;
                    LogicSw = 0;
                    Stage1 = new Stage(MultiplierOneQua, MultiplierTwoQua, MultiplierOneQua);
                    Stage1.Answer = StageMultiplication[0].Answer;
                    for (int i = 0; i < TempInt; i++)
                    {
                        if (LogicSw == 0)
                        {
                            if (StageMultiplication[i].Answer.Length != StageMultiplication[i + 1].Answer.Length)
                            {
                                counter++;
                            }
                            LogicSw = 1;
                            MultiplierOneMtemp = new double[MultiplierOneQua + counter];
                            MultiplierTwoMtemp = new double[MultiplierOneQua + counter];
                            StageMultiplication[i].Answer.CopyTo(MultiplierOneMtemp, MultiplierOneQua + counter - StageMultiplication[i].Answer.Length);
                            StageMultiplication[i + 1].Answer.CopyTo(MultiplierTwoMtemp, MultiplierOneQua + counter - StageMultiplication[i + 1].Answer.Length - (i + 1));
                            Add = new Addition(MultiplierOneMtemp, MultiplierTwoMtemp);
                            if (Add.Calculate())
                            {
                                Stage1.Answer = Add.StageAdd[0].Answer;
                            }
                            continue;
                        }
                        if (LogicSw == 1)
                        {
                            if (Stage1.Answer.Length != MultiplierOneQua + counter)
                            {
                                counter++;
                            }
                            MultiplierOneMtemp = new double[MultiplierOneQua + counter];
                            MultiplierTwoMtemp = new double[MultiplierOneQua + counter];
                            Stage1.Answer.CopyTo(MultiplierOneMtemp, MultiplierOneQua + counter - Stage1.Answer.Length);
                            StageMultiplication[i + 1].Answer.CopyTo(MultiplierTwoMtemp, MultiplierOneQua + counter - StageMultiplication[i + 1].Answer.Length - (i + 1));
                            Add = new Addition(Stage1.Answer, MultiplierTwoMtemp);
                            if (Add.Calculate())
                            {
                                Stage1.Answer = Add.StageAdd[0].Answer;
                            }
                            continue;
                        }
                    }
                    if (MultiplierOneNegative && !MultiplierTwoNegative || !MultiplierOneNegative && MultiplierTwoNegative)
                    {
                        Stage1.AnswerNegative = true;
                    }
                    StageMultiplication.Add(Stage1);
                    StageMultiplication[0].NumberOne = MultiplierOneM;
                    StageMultiplication[0].NumberTwo = MultiplierTwoM;
                }
                return true;
            }
        }

        public class Addition
        {
            bool Logic = false;
            public string AddendOne;
            public string AddendTwo;
            public double[] AddendOneM; public double[] AddendOneMtemp;
            public double[] AddendTwoM; public double[] AddendTwoMtemp;
            public List<Stage> StageAdd = new List<Stage>();
            public Addition(string s1, string s2) { AddendOne = s1; AddendTwo = s2; }
            public Addition(double[] s1, double[] s2) { AddendOneM = new double[s1.Length]; AddendTwoM = new double[s1.Length]; s1.CopyTo(AddendOneM, 0); s2.CopyTo(AddendTwoM, 0); Logic = true; }
            public bool Calculate()
            {
                Stage Stage1;
                bool AddendOneNegative = false; bool AddendTwoNegative = false;
                int AddendOneQua = 0; int AddendOneQuaBefComma = 0; int AddendOneQuaAftComma = 0;
                int AddendTwoQua = 0; int AddendTwoQuaBefComma = 0; int AddendTwoQuaAftComma = 0;
                int MaxBefComma = 0; int MaxAftComma = 0;
                int index = 0;
                if (!Logic)
                {
                    if (!Serviсe.CheckNumber(AddendOne, AddendTwo))
                    {
                        return false;
                    }
                    AddendOneQua = Serviсe.StringNumberQua(AddendOne);
                    AddendTwoQua = Serviсe.StringNumberQua(AddendTwo);
                    if (AddendOneQua > AddendTwoQua)
                    {
                        AddendOneM = new double[AddendOneQua];
                        AddendTwoM = new double[AddendOneQua];
                    }
                    else
                    {
                        AddendOneM = new double[AddendTwoQua];
                        AddendTwoM = new double[AddendTwoQua];
                    }
                    Serviсe.StringToMass(AddendOne, AddendOneM, AddendOneQua, AddendOneNegative);
                    Serviсe.StringToMass(AddendTwo, AddendTwoM, AddendTwoQua, AddendTwoNegative);
                }
                AddendOneQuaBefComma = Serviсe.NumberQuaBeforeComma(AddendOneM); AddendOneQuaAftComma = Serviсe.NumberQuaAfterComma(AddendOneM);
                AddendTwoQuaBefComma = Serviсe.NumberQuaBeforeComma(AddendTwoM); AddendTwoQuaAftComma = Serviсe.NumberQuaAfterComma(AddendTwoM);
                if (Logic)
                {
                    AddendOneQua = AddendOneQuaBefComma + AddendOneQuaAftComma;
                    if (AddendOneQuaAftComma > 0)
                    {
                        AddendOneQua++;
                    }
                    AddendTwoQua = AddendTwoQuaBefComma + AddendTwoQuaAftComma;
                    if (AddendTwoQuaAftComma > 0)
                    {
                        AddendTwoQua++;
                    }
                }
                MaxBefComma = Serviсe.MaxNumber(AddendOneQuaBefComma, AddendTwoQuaBefComma);
                MaxAftComma = Serviсe.MaxNumber(AddendOneQuaAftComma, AddendTwoQuaAftComma);
                index = MaxAftComma + MaxBefComma;
                if (MaxAftComma > 0)
                {
                    index++;
                }
                if (index > AddendOneM.Length)
                {
                    AddendOneMtemp = new double[index];
                    AddendTwoMtemp = new double[index];
                    if (MaxAftComma > AddendOneQuaAftComma)
                    {
                        AddendOneM.CopyTo(AddendOneMtemp, 0);
                        AddendTwoM.CopyTo(AddendTwoMtemp, index - AddendTwoM.Length);
                    }
                    else
                    {
                        AddendTwoM.CopyTo(AddendTwoMtemp, 0);
                        AddendOneM.CopyTo(AddendOneMtemp, index - AddendOneM.Length);
                    }
                    AddendOneM = new double[index];
                    AddendTwoM = new double[index];
                    AddendOneMtemp.CopyTo(AddendOneM, 0);
                    AddendTwoMtemp.CopyTo(AddendTwoM, 0);
                }
                AddendOneMtemp = new double[index];
                AddendTwoMtemp = new double[index];
                if (Serviсe.NumberCorrect(AddendOneM, AddendTwoM, AddendOneMtemp, AddendTwoMtemp, AddendOneQua, AddendTwoQua))
                {
                    AddendOneM = AddendOneMtemp;
                    AddendTwoM = AddendTwoMtemp;
                }
                if (index < AddendOneM.Length)
                {
                    index = AddendOneM.Length;
                }
                Stage1 = new Stage(index);
                AddendOneM.CopyTo(Stage1.NumberOne, 0);
                AddendTwoM.CopyTo(Stage1.NumberTwo, 0);
                for (int i = index - 1; i >= 0; i--)
                {
                    if (AddendOneM[i] == 0.5 || AddendTwoM[i] == 0.5)
                    {
                        Stage1.Answer[i] = 0.5;
                        continue;
                    }
                    if (AddendTwoM[i] + AddendOneM[i] > 9)
                    {
                        Stage1.Answer[i] = 0;
                        if (i == 0)
                        {
                            AddendOneM = new double[index + 1];
                            Stage1.Answer.CopyTo(AddendOneM, 1);
                            AddendOneM[0] = 1;
                            Stage1.Answer = AddendOneM;
                            break;
                        }
                        if (AddendOneM[i - 1] != 0.5 && AddendTwoM[i - 1] != 0.5)
                        {
                            AddendOneM[i - 1]++;
                        }
                        else
                        {
                            AddendOneM[i - 2]++;
                        }
                        continue;
                    }
                    Stage1.Answer[i] = AddendTwoM[i] + AddendOneM[i];
                }
                StageAdd.Add(Stage1);
                return true;
            }

        }


        public class Subtraction
        {
            bool Logic = false;
            public string Minuend;
            public string SuBtraction;
            public double[] MinuendM; public double[] MinuendMtemp;
            public double[] SuBtractionM; public double[] SuBtractionMtemp;
            public List<Stage> StageSubtraction = new List<Stage>();
            public Subtraction(string s1, string s2) { Minuend = s1; SuBtraction = s2; }
            public Subtraction(double[] s1, double[] s2) { MinuendM = new double[s1.Length]; SuBtractionM = new double[s1.Length]; s1.CopyTo(MinuendM, 0); s2.CopyTo(SuBtractionM, 0); Logic = true; }
            public bool Calculate()
            {
                Stage Stage1;
                bool MinuendNegative = false; bool SuBtractionNegative = false; bool NegativeTemp;
                int MinuendQua = 0; int MinuendQuaBefComma = 0; int MinuendQuaAftComma = 0;
                int SuBtractionQua = 0; int SuBtractionQuaBefComma = 0; int SuBtractionQuaAftComma = 0;
                int MaxBefComma = 0; int MaxAftComma = 0;
                int index = 0;
                if (!Logic)
                {
                    if (!Serviсe.CheckNumber(Minuend, SuBtraction))
                    {
                        return false;
                    }
                    MinuendQua = Serviсe.StringNumberQua(Minuend);
                    SuBtractionQua = Serviсe.StringNumberQua(SuBtraction);
                    if (MinuendQua > SuBtractionQua)
                    {
                        MinuendM = new double[MinuendQua];
                        SuBtractionM = new double[MinuendQua];
                    }
                    else
                    {
                        MinuendM = new double[SuBtractionQua];
                        SuBtractionM = new double[SuBtractionQua];
                    }
                    Serviсe.StringToMass(Minuend, MinuendM, MinuendQua, MinuendNegative);
                    Serviсe.StringToMass(SuBtraction, SuBtractionM, SuBtractionQua, SuBtractionNegative);
                }
                MinuendQuaBefComma = Serviсe.NumberQuaBeforeComma(MinuendM); MinuendQuaAftComma = Serviсe.NumberQuaAfterComma(MinuendM);
                SuBtractionQuaBefComma = Serviсe.NumberQuaBeforeComma(SuBtractionM); SuBtractionQuaAftComma = Serviсe.NumberQuaAfterComma(SuBtractionM);
                if (Logic)
                {
                    MinuendQua = MinuendQuaBefComma + MinuendQuaAftComma;
                    if (MinuendQuaAftComma > 0)
                    {
                        MinuendQua++;
                    }
                    SuBtractionQua = SuBtractionQuaBefComma + SuBtractionQuaAftComma;
                    if (SuBtractionQuaAftComma > 0)
                    {
                        SuBtractionQua++;
                    }
                }
                MaxBefComma = Serviсe.MaxNumber(MinuendQuaBefComma, SuBtractionQuaBefComma);
                MaxAftComma = Serviсe.MaxNumber(MinuendQuaAftComma, SuBtractionQuaAftComma);
                index = MaxAftComma + MaxBefComma;
                if (MaxAftComma > 0)
                {
                    index++;
                }
                if (index > MinuendM.Length)
                {
                    MinuendMtemp = new double[index];
                    SuBtractionMtemp = new double[index];
                    if (MaxAftComma > MinuendQuaAftComma)
                    {
                        MinuendM.CopyTo(MinuendMtemp, 0);
                        SuBtractionM.CopyTo(SuBtractionMtemp, index - SuBtractionM.Length);
                    }
                    else
                    {
                        SuBtractionM.CopyTo(SuBtractionMtemp, 0);
                        MinuendM.CopyTo(MinuendMtemp, index - MinuendM.Length);
                    }
                    MinuendM = new double[index];
                    SuBtractionM = new double[index];
                    MinuendMtemp.CopyTo(MinuendM, 0);
                    SuBtractionMtemp.CopyTo(SuBtractionM, 0);
                }
                MinuendMtemp = new double[index];
                SuBtractionMtemp = new double[index];
                if (Serviсe.NumberCorrect(MinuendM, SuBtractionM, MinuendMtemp, SuBtractionMtemp, MinuendQua, SuBtractionQua))
                {
                    MinuendM = MinuendMtemp;
                    SuBtractionM = SuBtractionMtemp;
                }

                Stage1 = new Stage(index);
                if (Serviсe.NumberCompare(MinuendM, SuBtractionM, MinuendNegative, SuBtractionNegative) == 2)
                {
                    SuBtractionMtemp = new double[index];
                    MinuendMtemp = new double[index];
                    MinuendM.CopyTo(SuBtractionMtemp, 0);
                    SuBtractionM.CopyTo(MinuendMtemp, 0);
                    MinuendM = MinuendMtemp;
                    SuBtractionM = SuBtractionMtemp;
                    NegativeTemp = MinuendNegative;
                    MinuendNegative = SuBtractionNegative;
                    SuBtractionNegative = NegativeTemp;
                    Stage1.AnswerNegative = true;
                }
                MinuendM.CopyTo(Stage1.NumberOne, 0);
                SuBtractionM.CopyTo(Stage1.NumberTwo, 0);
                Stage1.NumberOneNegative = MinuendNegative;
                Stage1.NumberTwoNegative = SuBtractionNegative;
                for (int i = index - 1; i >= 0; i--)
                {
                    if (MinuendM[i] == 0.5 || SuBtractionM[i] == 0.5)
                    {
                        Stage1.Answer[i] = 0.5;
                        continue;
                    }
                    if (MinuendM[i] - SuBtractionM[i] < 0)
                    {
                        Stage1.Answer[i] = 10 + MinuendM[i] - SuBtractionM[i];
                        if (MinuendM[i - 1] != 0.5 && SuBtractionM[i - 1] != 0.5)
                        {
                            MinuendM[i - 1]--;
                        }
                        else
                        {
                            MinuendM[i - 2]--;
                        }
                        continue;
                    }
                    Stage1.Answer[i] = MinuendM[i] - SuBtractionM[i];
                }
                StageSubtraction.Add(Stage1);
                return true;
            }

        }



        public static class Serviсe
        {
            private static int QuaNumb1;
            private static int QuaNumb2;
            private static int LogSwitch;
            public static bool CheckNumber(string numb1, string numb2)
            {
                QuaNumb1 = numb1.Length;
                QuaNumb2 = numb2.Length;
                LogSwitch = 0;
                for (int i = 0; i < QuaNumb1; i++)
                {
                    if (LogSwitch == 0 && numb1[i] > 47 && numb1[i] < 58)
                    {
                        LogSwitch = 1;
                        continue;
                    }
                    if (LogSwitch == 1 && (numb1[i] == 44 || numb1[i] == 46))
                    {
                        LogSwitch = 2;
                        continue;
                    }
                    if (LogSwitch < 3 && LogSwitch > 0 && numb1[i] == 32)
                    {
                        LogSwitch = 3;
                        continue;
                    }
                    if (LogSwitch == 3 && numb1[i] != 32)
                    {
                        return false;
                    }
                    if (LogSwitch > 0 && LogSwitch < 3 && (numb1[i] < 48 || numb1[i] > 57))
                    {
                        return false;
                    }
                }
                if (LogSwitch == 0)
                {
                    return false;
                }
                LogSwitch = 0;
                for (int i = 0; i < QuaNumb2; i++)
                {
                    if (LogSwitch == 0 && numb2[i] > 47 && numb2[i] < 58)
                    {
                        LogSwitch = 1;
                        continue;
                    }
                    if (LogSwitch == 1 && (numb2[i] == 44 || numb2[i] == 46))
                    {
                        LogSwitch = 2;
                        continue;
                    }
                    if (LogSwitch < 3 && numb2[i] == 32)
                    {
                        LogSwitch = 3;
                        continue;
                    }
                    if (LogSwitch == 3 && numb2[i] != 32)
                    {
                        return false;
                    }
                    if (LogSwitch > 0 && LogSwitch < 3 && (numb2[i] < 48 || numb2[i] > 57))
                    {
                        return false;
                    }
                }
                if (LogSwitch == 0)
                {
                    return false;
                }
                return true;
            }
            public static int StringNumberQua(string numb1)
            {
                QuaNumb1 = numb1.Length;
                QuaNumb2 = 0;
                LogSwitch = 0;
                for (int i = 0; i < QuaNumb1; i++)
                {
                    if (numb1[i] > 47 && numb1[i] < 58)
                    {
                        if (LogSwitch == 0 && numb1[i] == 48)
                        {
                            LogSwitch = 1;
                            continue;
                        }
                        LogSwitch = 1;
                        QuaNumb2++;
                        continue;
                    }
                    if (LogSwitch == 1 && (numb1[i] == 44 || numb1[i] == 46))
                    {
                        LogSwitch = 2;
                        QuaNumb2++;
                        continue;
                    }
                    if (LogSwitch > 0 && LogSwitch < 3 && (numb1[i] < 48 || numb1[i] > 57))
                    {
                        return QuaNumb2;
                    }
                }
                return QuaNumb2;
            }
            public static void StringToMass(string StringNumber, double[] number, int NumberQua, bool NumberNegative)
            {
                NumberNegative = false;
                QuaNumb1 = StringNumber.Length;
                QuaNumb2 = 0;
                LogSwitch = 0;
                if (number.Length != NumberQua)
                {
                    QuaNumb2 = number.Length - NumberQua;
                }
                for (int i = 0, u = QuaNumb2; i < QuaNumb1; i++)
                {
                    if (LogSwitch == 0 && StringNumber[i] == 45)
                    {
                        NumberNegative = true;
                    }
                    if (StringNumber[i] > 47 && StringNumber[i] < 58)
                    {
                        if (LogSwitch == 0 && StringNumber[i] == 48)
                        {
                            LogSwitch = 1;
                            continue;
                        }
                        QuaNumb2 = StringNumber[i];
                        switch (QuaNumb2)
                        {
                            case 48:
                                {
                                    number[u] = 0;
                                    break;
                                }
                            case 49:
                                {
                                    number[u] = 1;
                                    break;
                                }
                            case 50:
                                {
                                    number[u] = 2;
                                    break;
                                }
                            case 51:
                                {
                                    number[u] = 3;
                                    break;
                                }
                            case 52:
                                {
                                    number[u] = 4;
                                    break;
                                }
                            case 53:
                                {
                                    number[u] = 5;
                                    break;
                                }
                            case 54:
                                {
                                    number[u] = 6;
                                    break;
                                }
                            case 55:
                                {
                                    number[u] = 7;
                                    break;
                                }
                            case 56:
                                {
                                    number[u] = 8;
                                    break;
                                }
                            case 57:
                                {
                                    number[u] = 9;
                                    break;
                                }
                        }
                        u++;
                        LogSwitch = 1;
                        continue;
                    }
                    if (LogSwitch == 1 && (StringNumber[i] == 44 || StringNumber[i] == 46))
                    {
                        LogSwitch = 2;
                        number[u] = 0.5;
                        u++;
                        continue;
                    }
                    if (LogSwitch > 0 && LogSwitch < 3 && (StringNumber[i] < 48 || StringNumber[i] > 57))
                    {
                        return;
                    }
                }
            }
            public static int NumberQuaBeforeComma(double[] num)
            {
                LogSwitch = 0;
                QuaNumb2 = 0;
                foreach (double i in num)
                {
                    if (i > 0.5)
                    {
                        LogSwitch = 1;
                    }
                    if (i == 0.5)
                    {
                        if (LogSwitch == 0)
                        {
                            QuaNumb2++;
                        }
                        return QuaNumb2;
                    }
                    if (LogSwitch == 0)
                    {
                        continue;
                    }
                    QuaNumb2++;
                }
                return QuaNumb2;
            }
            public static int NumberQuaAfterComma(double[] num)
            {
                LogSwitch = 0;
                QuaNumb2 = 0;
                foreach (double i in num)
                {
                    if (i == 0.5)
                    {
                        LogSwitch = 1;
                        continue;
                    }
                    if (LogSwitch == 1)
                    {
                        QuaNumb2++;
                    }
                }
                return QuaNumb2;
            }
            public static int MaxNumber(int a, int b)
            {
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            public static bool NumberCorrect(double[] number1, double[] number2, double[] number1temp, double[] number2temp, int number1Qua, int number2Qua)
            {
                LogSwitch = 0;
                QuaNumb1 = 0;
                QuaNumb2 = 0;

                for (int i = 0; i < number1.Length; i++)
                {
                    if (number1[i] == 0.5)
                    {
                        LogSwitch = 1;
                        QuaNumb1 = i;
                        if (number2[QuaNumb1] == 0.5)
                        {
                            return false;
                        }
                        break;
                    }
                }
                for (int i = 0; i < number2.Length; i++)
                {
                    if (number2[i] == 0.5)
                    {
                        LogSwitch = 1;
                        QuaNumb2 = i;
                        if (number1[QuaNumb2] == 0.5)
                        {
                            return false;
                        }
                        break;
                    }
                }
                if (LogSwitch == 1 && QuaNumb2 == 0)
                {
                    for (int i = 0; i < number2.Length; i++)
                    {
                        if (number2[i] > 0)
                        {
                            QuaNumb2 = i;
                            LogSwitch = 2;
                            break;
                        }

                    }
                    Array.Copy(number2, QuaNumb2, number2temp, 0, number2Qua);
                    number2temp[number2Qua] = 0.5;
                    number1.CopyTo(number1temp, 0);
                    return true;
                }
                if (LogSwitch == 1 && QuaNumb1 == 0)
                {
                    for (int i = 0; i < number1.Length; i++)
                    {
                        if (number1[i] > 0)
                        {
                            QuaNumb1 = i;
                            LogSwitch = 2;
                            break;
                        }

                    }
                    Array.Copy(number1, QuaNumb1, number1temp, 0, number1Qua);
                    number1temp[number1Qua] = 0.5;
                    number2.CopyTo(number2temp, 0);
                    return true;

                }
                LogSwitch = 1;
                if (QuaNumb1 > QuaNumb2)
                {
                    for (int i = 0, u = QuaNumb1 - QuaNumb2; i < number1.Length; i++)
                    {
                        if (LogSwitch == 1 && number1[i] == 0)
                        {
                            u--;
                            if (u == 0)
                            {
                                Array.Copy(number1, QuaNumb1 - QuaNumb2, number1temp, 0, number1.Length - (QuaNumb1 - QuaNumb2));
                                number2.CopyTo(number2temp, 0);
                                return true;
                            }
                        }
                    }
                }
                if (QuaNumb2 > QuaNumb1)
                {
                    for (int i = 0, u = QuaNumb2 - QuaNumb1; i < number2.Length; i++)
                    {
                        if (LogSwitch == 1 && number2[i] == 0)
                        {
                            u--;
                            if (u == 0)
                            {
                                Array.Copy(number2, QuaNumb2 - QuaNumb1, number2temp, 0, number2.Length - (QuaNumb2 - QuaNumb1));
                                number1.CopyTo(number1temp, 0);
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
            public static int NumberCompare(double[] number1, double[] number2, bool number1Negative, bool number2Negative)
            {
                if (number1Negative && !number2Negative)
                {
                    return 2;
                }
                if (!number1Negative && number2Negative)
                {
                    return 1;
                }
                for (int i = 0; i < number1.Length; i++)
                {
                    if (number1[i] > number2[i])
                    {
                        return 1;
                    }
                    if (number1[i] < number2[i])
                    {
                        return 2;
                    }
                }
                return 0;
            }
        }
        public class Stage
        {
            public double[] NumberOne; public bool NumberOneNegative = false;
            public double[] NumberTwo; public bool NumberTwoNegative = false;
            public double[] Answer; public bool AnswerNegative = false;
            public Stage(int n1) { NumberOne = new double[n1]; NumberTwo = new double[n1]; Answer = new double[n1]; }
            public Stage(int n1, int n2) { NumberOne = new double[n1]; NumberTwo = new double[n1]; Answer = new double[n2]; }
            public Stage(int n1, int n2, int n3) { NumberOne = new double[n1]; NumberTwo = new double[n2]; Answer = new double[n3]; }
        }

    }
}

#region 2 Tipos de dados
byte tipoByte; 
sbyte tipoSByte; 
short tipoShort ;
ushort tipoUShort; 
int tipoInt; 
uint tipoUInt; 
long tipoLong; 
ulong tipoULong;

tipoByte = byte.MaxValue;
tipoSByte = sbyte.MaxValue;
tipoShort =short.MaxValue;
tipoUShort = ushort.MaxValue;
tipoInt = int.MaxValue;
tipoUInt = uint.MaxValue;
tipoLong = long.MaxValue;
tipoULong = ulong.MaxValue;

Console.WriteLine(" Valor maximo de um byte:  " + tipoByte);
Console.WriteLine(" Valor maximo de um sbyte:  " + tipoSByte);
Console.WriteLine(" Valor maximo de um short:  " + tipoShort);
Console.WriteLine(" Valor maximo de um ushort:  " + tipoUShort);
Console.WriteLine(" Valor maximo de um int:  " + tipoInt);
Console.WriteLine(" Valor maximo de um uint:  " + tipoUInt);
Console.WriteLine(" Valor maximo de um long:  " + tipoLong);
Console.WriteLine(" Valor maximo de um ulong:  " + tipoULong);
#endregion
#region 3 Conversao de tipos de dados
double numDouble =  10.75;
int numInt;

numDouble = (int)Math.Round(numDouble);
numInt = Convert.ToInt32(numDouble);
Console.WriteLine("Conversao:" + numInt);
#endregion

#region 4 Operadores Aritmeticos
int x = 10;
int y = 3;
int soma, multiplicacao, subtracao;
float divisao;

soma = x + y;
subtracao = x - y;
multiplicacao = x*y;
divisao = x/y;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtracao: {subtracao}");
Console.WriteLine($"Multiplicacao: {multiplicacao}");
Console.WriteLine($"Divisao: {divisao}");
#endregion

#region 5 Operadores de Comparacao
    int a = 5;
    int b =8;

    if (a > b)
        {
            Console.WriteLine("a é maior que b.");
        }
    
    else
        {
            Console.WriteLine("a não é maior que b.");
        }
#endregion

#region 6 Operadores de Igualdade
string str1 = "Hello";
string str2 = "World";
bool strIguais;
strIguais = str1.Equals(str2);
Console.WriteLine($"As strings são iguais? {strIguais}");    
#endregion

#region 7 Operadores Logicos
bool condicao1 = true;
bool condicao2 = false;

bool condicoesVerdadeiras = condicao1 && condicao2;
Console.WriteLine($"As condicoes sao verdadeiras? {condicoesVerdadeiras}");
#endregion

#region 8 Desafio de Mistura de Operadores
int num1 = 7;
int num2 = 3;
int num3 = 10;

bool num1MaiorQueNum2 = num1 > num2;
bool num3IgualSomaNum1Num2 = num3 == (num1 + num2);
Console.WriteLine($"num1 é maior do que num2? {num1MaiorQueNum2}");
Console.WriteLine($"num3 é igual a num1 + num2? {num3IgualSomaNum1Num2}");
#endregion

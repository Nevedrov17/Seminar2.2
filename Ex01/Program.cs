Console.Clear();

//1) МАССИВ ИЗ СТРОК

string name1 = "Bob";
string name2 = "Shmob";
string name3 = "Shirli";
string name4 = "Mirli";

string [] names = { name1, name2, name3, name4};
Console.WriteLine(names[1]);
names[1]= "Sheldin";
Console.WriteLine(names[1]);

//2) МАССИВ ИЗ ЦЕЛЫХ ЧИСЕЛ

//int[] age = new int[5];
/*int[] age = {1,2,3,4,5};
Console.WriteLine(age[1]);
age[1]=age[1]+5;
Console.WriteLine(age[1]);
Console.WriteLine(age.Length);*/

for(int i = 0; i < names.Length; i++ )
Console.WriteLine(names[i]);




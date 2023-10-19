int numbA = new Random().Next(-20, 20);
int numbB = new Random().Next(-20, 20);
int sum = numbA + numbB;

if (numbB < 0){
    Console.WriteLine($"{numbA}+({numbB})={sum}");
}
else{
    Console.WriteLine($"{numbA}+{numbB}={sum}");
}

double numbX = new Random().Next(-20, 20);
double numbY = new Random().Next(-20, 20);
double division = numbX/numbY;

if (numbX !=0){
   division = numbX / numbY;
}
else{
    numbX++;
    division = numbX++ / numbY;
}

if (numbY !=0){
   division = numbX / numbY;
}
else{
    numbY++;
    division = numbX++ / numbY;
}

if (numbB < 0){
    Console.WriteLine($"{numbX}:({numbY})={division}");
}
else{
    Console.WriteLine($"{numbX}:{numbY}={division}");
}

int numbC = new Random().Next(-20, 20);
int numbD = new Random().Next(-20, 20);
int product = numbC * numbD;

if (numbB < 0){
    Console.WriteLine($"{numbC}*({numbD})={product}");
}
else{
    Console.WriteLine($"{numbC}*{numbD}={product}");
}

int numbZ = new Random().Next(-20, 20);
int numbE = new Random().Next(-20, 20);
int difference = numbZ - numbE;

if (numbB < 0){
    Console.WriteLine($"{numbZ}-({numbE})={difference}");
}
else{
    Console.WriteLine($"{numbZ}-{numbE}={difference}");
}


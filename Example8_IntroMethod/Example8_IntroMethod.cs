int a1 = 3;
int b1 = 24;
int c1 = 45;
int a2 = 1;
int b2 = 14;
int c2 = 67;
int a3 = 387;
int b3 = 241;
int c3 = 4;

int max = a1;

if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.Write("Max number is ");
Console.Write(max);


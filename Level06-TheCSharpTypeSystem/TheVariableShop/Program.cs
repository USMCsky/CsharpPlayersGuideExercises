// Declarations and initialization
int a = 3;
uint b = 3;

short c = 3;
ushort d = 3;

long e = 3;
ulong f = 3;

byte g = 3;
sbyte h = 3;

char i = '3';
string j = "3";

bool k = true;

float l = 3.0f;
double m = 3.0;
decimal n = 3.0m;

// Display with type and value using string interpolation
Console.WriteLine($"{nameof(a)}: Type = {a.GetType().Name}, Value = {a}");
Console.WriteLine($"{nameof(b)}: Type = {b.GetType().Name}, Value = {b}");
Console.WriteLine($"{nameof(c)}: Type = {c.GetType().Name}, Value = {c}");
Console.WriteLine($"{nameof(d)}: Type = {d.GetType().Name}, Value = {d}");
Console.WriteLine($"{nameof(e)}: Type = {e.GetType().Name}, Value = {e}");
Console.WriteLine($"{nameof(f)}: Type = {f.GetType().Name}, Value = {f}");
Console.WriteLine($"{nameof(g)}: Type = {g.GetType().Name}, Value = {g}");
Console.WriteLine($"{nameof(h)}: Type = {h.GetType().Name}, Value = {h}");
Console.WriteLine($"{nameof(i)}: Type = {i.GetType().Name}, Value = {i}");
Console.WriteLine($"{nameof(j)}: Type = {j.GetType().Name}, Value = {j}");
Console.WriteLine($"{nameof(k)}: Type = {k.GetType().Name}, Value = {k}");
Console.WriteLine($"{nameof(l)}: Type = {l.GetType().Name}, Value = {l}");
Console.WriteLine($"{nameof(m)}: Type = {m.GetType().Name}, Value = {m}");
Console.WriteLine($"{nameof(n)}: Type = {n.GetType().Name}, Value = {n}");
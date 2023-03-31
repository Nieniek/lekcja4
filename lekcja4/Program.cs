//tekst do zaszyfrrowania
string clearText = "GADERYPOLUKI";
//zmienna do przechowwania zaszyfrowanego tekstu
string cypherText = "";
//zmien G na A i zapisz do nowej zmiennej
cypherText = clearText.Replace('G', '@');
//wez juz czesciowo zaszyfrowany tekst i zmien A na G
cypherText = clearText.Replace('A', 'G');
cypherText = clearText.Replace('@', 'G');
//d->e, e->d
cypherText = clearText.Replace('D', '@');
cypherText = clearText.Replace('@', 'E');
cypherText = clearText.Replace('E', 'D');
//r->y, y->r
cypherText = clearText.Replace('R', '@');
cypherText = clearText.Replace('@', 'Y');
cypherText = clearText.Replace('Y', 'R');
//p->o, o->p
cypherText = clearText.Replace('P', '@');
cypherText = clearText.Replace('@', 'O');
cypherText = clearText.Replace('O', 'P');
//l->u, u->l
cypherText = clearText.Replace('L', '@');
cypherText = clearText.Replace('@', 'U');
cypherText = clearText.Replace('U', 'L');
//k->i, i->k
cypherText = clearText.Replace('K', '@');
cypherText = clearText.Replace('@', 'I');
cypherText = clearText.Replace('I', 'K');

Console.WriteLine("Zaszyfrowany tekst " + cypherText);
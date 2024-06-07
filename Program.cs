
static int soma(int vitorias, int derrotas){
    int saldoVitorias = vitorias - derrotas;
    return saldoVitorias;
}
    int saldoVitorias = soma(55, 14);
    string nivel;
    switch (saldoVitorias)
    {
        case < 10:
            nivel = "Ferro";
        break;
        
        case <= 20:
            nivel = "Bronze";
        break;

        case <= 50:
            nivel = "Prata";
        break;

        case <= 80:
            nivel = "Ouro";
        break;

        case <= 90:
            nivel = "Diamante";
        break;

        case <= 100:
            nivel = "Lendário";
        break;

        case >= 101:
            nivel = "Imortal";
        break;
    }

    System.Console.WriteLine($"O Herói com saldo de {saldoVitorias} vitórias, está no nível de {nivel}.");
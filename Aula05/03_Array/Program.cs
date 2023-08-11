// --> Compreendendo Arrays

int? [] vetor = new int?[10];
Random rd = new Random();

// --> Coloca números aleatórios em cada índice do vetor
for(int i = 0; i < vetor.Length; i++){
    vetor[i] = rd.Next(101);
}

// --> Imprime cada valor do vetor
for(int i = 0; i < vetor.Length; i++){
    Console.WriteLine($"[{i}]: {vetor[i]}");
}

Console.WriteLine("| ======================= |");
// --> No ForEach não é possível modificar o valor, apenas consultar
foreach(int valor in vetor){
    Console.WriteLine($"fe -> {valor}");
}

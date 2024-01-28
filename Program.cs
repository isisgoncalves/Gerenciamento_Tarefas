class Program
{
  static void Main()
  {
    var titulo = "Atualizacao de Software";
		var descricao = "Aplicar patches";
		var dataVencimento = "22/12";
        
    titulo = Console.ReadLine();
    descricao = Console.ReadLine();

    if(descricao.Length > 50)
    {
      Console.WriteLine("Descricao ultrapassa limite de caracteres.");
    }
    else
    {
      dataVencimento = Console.ReadLine();
      Console.WriteLine(descricao + " ate "+ dataVencimento);
    }    
  }
}

namespace TypesAndDebug
{
  class TypesAndDebug
  {
    public string Name;
    public override string ToString()
    {
      string textOne = "Você está aprendendo sobre ";
      string textTwo = "Strings em C#, ";
      string textThree = "e agora sabe concatenar textos utilizando a função Concat()!";
      string res = string.Concat(textOne, textTwo, textThree);
      return $" {Name } {res}";
    }
  }
}
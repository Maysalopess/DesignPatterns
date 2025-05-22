using Decorator.Pizza;

Console.WriteLine("Criação de uma pizza de queijo");
Pizza pizzaQueijo = new PizzaQueijo();

//Impressão da prizza
Console.WriteLine("Produto-->" + pizzaQueijo.getDescricao() + " Valor R$ " + pizzaQueijo.getPreco());

Console.WriteLine(" ");
//Adicionar borda de queijo
Console.WriteLine("Adiciona borda de queijo");
Pizza pizzaBordaQueijo = new BordaRequeijao(pizzaQueijo);

Console.WriteLine("Produto-->" + pizzaBordaQueijo.getDescricao() + " Valor R$ " + pizzaBordaQueijo.getPreco());


Console.WriteLine(" ");
//Adicionar borda de queijo
Console.WriteLine("Adiciona massa integral");
Pizza pizzaBordaQueijoMassaIntegral = new MassaIntegral(pizzaBordaQueijo);

Console.WriteLine("Produto-->" + pizzaBordaQueijoMassaIntegral.getDescricao() + " Valor R$ " + pizzaBordaQueijoMassaIntegral.getPreco());

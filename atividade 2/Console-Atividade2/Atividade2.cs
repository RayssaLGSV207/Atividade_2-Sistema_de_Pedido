using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE CÁLCULO DE PEDIDO ===\n");
        
        Console.WriteLine("Digite os dados do pedido:\n");
        
        // Solicitar preço
        Console.Write("Digite o preço unitário do produto: R$");
        double preco = double.Parse(Console.ReadLine());
        
        // Solicitar quantidade 
        Console.Write("Digite a quantidade desejada: ");
        int quantidade = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\n--- PROCESSANDO PEDIDO ---");
        
        // Calcular e exibir resultado
        double total = CalcularTotal(preco, quantidade);
        
        if (total >= 0)
        {
            Console.WriteLine($"\n=== TOTAL FINAL: R${total:F2} ===");
        }
        
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
    
    static double CalcularSubtotal(double preco, int quantidade)
    {
        // Validar entradas
        if (preco < 0 || quantidade < 0)
        {
            Console.WriteLine("Erro: Valores não podem ser negativos!");
            return -1;
        }
        
        double subtotal = preco * quantidade;
        Console.WriteLine($"Subtotal: R${subtotal:F2}");
        return subtotal;
    }
    
    static double AplicarDesconto(double subtotal)
    {
        if (subtotal < 0) return subtotal;
        
        double desconto = 0;
        
        if (subtotal > 100)
        {
            desconto = subtotal * 0.10; // 10% de desconto
            Console.WriteLine($"Desconto (10%): -R${desconto:F2}");
        }
        else
        {
            Console.WriteLine($"Desconto: R$0,00");
        }
        
        return desconto;
    }
    
    static double CalcularFrete(double subtotal)
    {
        if (subtotal < 0) return subtotal;
        
        double frete = 0;
        
        if (subtotal >= 200)
        {
            Console.WriteLine("Frete: Grátis (R$0,00)");
        }
        else
        {
            frete = 20;
            Console.WriteLine($"Frete: R${frete:F2}");
        }
        
        return frete;
    }
    
    static double CalcularTotal(double preco, int quantidade)
    {
        // Passo 1: Calcular subtotal
        double subtotal = CalcularSubtotal(preco, quantidade);
        
        if (subtotal < 0) return -1;
        
        // Passo 2: Calcular desconto
        double desconto = AplicarDesconto(subtotal);
        
        // Passo 3: Aplicar desconto ao subtotal
        double aposDesconto = subtotal - desconto;
        Console.WriteLine($"Total após desconto: R${aposDesconto:F2}");
        
        // Passo 4: Calcular frete
        double frete = CalcularFrete(aposDesconto);
        
        // Passo 5: Calcular total final
        double total = aposDesconto + frete;
        
        return total;
    }
    
    // Desafio extra: método com parâmetro out
    static void CalcularTotalOut(double preco, int quantidade, out double total, out double desconto)
    {
        double subtotal = preco * quantidade;
        
        if (subtotal > 100)
            desconto = subtotal * 0.10;
        else
            desconto = 0;
        
        double aposDesconto = subtotal - desconto;
        double frete = aposDesconto >= 200 ? 0 : 20;
        
        total = aposDesconto + frete;
    }
}

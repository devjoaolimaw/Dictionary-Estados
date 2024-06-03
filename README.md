# Dictionary-Estados

Esse código em C# cria e manipula um dicionário chamado "estados" que mapeia siglas de estados brasileiros para seus nomes completos. Vamos analisar cada parte:

1. **Criação do dicionário**: `Dictionary<string, string> estados = new Dictionary<string, string>();`
   - Aqui, um dicionário vazio é criado. Ele vai conter pares de chave-valor, onde a chave é uma string (representando a sigla do estado) e o valor é outra string (representando o nome completo do estado).

2. **Adição de elementos ao dicionário**:
   ```csharp
   estados.Add("SP", "São Paulo");
   estados.Add("BA", "Bahia");
   estados.Add("MG", "Minas Gerais");
   ```
   - Aqui, três estados são adicionados ao dicionário com suas respectivas siglas e nomes completos.

3. **Acesso e impressão de valores**:
   ```csharp
   Console.WriteLine(estados["MG"]);
   ```
   - Isso imprime o valor associado à chave "MG", que é "Minas Gerais".

4. **Iteração sobre os elementos do dicionário**:
   ```csharp
   foreach(var item in estados)
   {
       Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
   }
   ```
   - Aqui, cada par chave-valor do dicionário é impresso no console.

5. **Remoção de um elemento do dicionário**:
   ```csharp
   estados.Remove("BA");
   ```
   - Remove o elemento com a chave "BA" do dicionário.

6. **Atualização de um valor no dicionário**:
   ```csharp
   estados["SP"] = "São Paulo - valor alterado";
   ```
   - Atualiza o valor associado à chave "SP" no dicionário.

7. **Impressão dos elementos atualizados**:
   ```csharp
   foreach(var item in estados)
   {
       Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
   }
   ```
   - Imprime novamente todos os elementos do dicionário após a remoção e a atualização.

8. **Verificação de existência de uma chave no dicionário**:
   ```csharp
   string chave = "BA";
   Console.WriteLine($"Verificando o elemento: {chave}");

   if(estados.ContainsKey(chave))
   {
       Console.WriteLine($"Valor existente:{chave}");
   }
   else
   {
      Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
   }
   ```
   - Verifica se o dicionário contém a chave "BA" e imprime uma mensagem correspondente. Neste caso, como "BA" foi removido anteriormente, a mensagem indica que a chave não existe e sugere que seja seguro adicionar.

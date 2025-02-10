# Uso Correto de Letras Maiúsculas
Este repositório contém uma solução em C# para o problema "Uso Correto de Letras Maiúsculas". O código verifica se o uso de letras maiúsculas em uma palavra está correto de acordo com as regras especificadas.

## Descrição do Problema
Definimos que o uso de letras maiúsculas em uma palavra está correto quando uma das seguintes condições é atendida:

Todas as letras da palavra são maiúsculas, como em "USA".
Todas as letras da palavra são minúsculas, como em "leetcode".
Apenas a primeira letra da palavra é maiúscula, como em "Google".
Dada uma string word, a função retorna true se o uso de letras maiúsculas estiver correto, caso contrário, retorna false.

#### Restrições (Constraints)
O comprimento da palavra (word.length) deve estar entre 1 e 100.
A palavra deve conter apenas letras maiúsculas ou minúsculas do alfabeto inglês (a-z, A-Z).

### Exemplos

Exemplo 1:
Entrada: "USA"
Saída: true

Exemplo 2:
Entrada: "FlaG"
Saída: false

Exemplo 3:
Entrada: "Google"
Saída: true

## Solução
A solução utiliza LINQ para verificar as condições de forma eficiente e legível. Além disso, o código inclui validações para garantir que as restrições do problema sejam atendidas.


## Como Realizar os Testes
 #### Passo 1: Configurar o Ambiente
Instale o .NET SDK:
Baixe e instale o .NET SDK a partir do site oficial.

Verifique a instalação executando no terminal:

dotnet --version

Instale o Visual Studio Code (VS Code):

Baixe e instale o VS Code a partir do site oficial.
Instale a Extensão C# no VS Code

Abra o VS Code, vá para a aba de extensões (Ctrl+Shift+X) e instale a extensão C# da Microsoft.

#### Passo 2: Criar um Projeto de Teste
Abra o terminal e crie um novo projeto de console:

dotnet new console -n DetectCapitalUsageTest

Navegue até a pasta do projeto:
cd DetectCapitalUsageTest
Abra o projeto no VS Code:
code .

#### Passo 3: Adicionar o Código da Solução
No VS Code, abra o arquivo Program.cs.
Substitua o conteúdo do arquivo pelo código fornecido acima.


### Constraints
No compilador do leetcode não é possível testar as restrições adicionados via dógio, você pode adicionar casos de teste inválidos no método Main. Por exemplo:

```
public class Solution {
    public bool DetectCapitalUse(string word) {
        // Validação das constraints
        if (word.Length < 1 || word.Length > 100) {
            throw new ArgumentException("A palavra deve ter entre 1 e 100 caracteres.");
        }

        if (!word.All(char.IsLetter)) {
            throw new ArgumentException("A palavra deve conter apenas letras maiúsculas ou minúsculas do alfabeto inglês.");
        }

        // Validando se todas as letras são maiúsculas ou minúsculas
        if (word.All(char.IsUpper) || word.All(char.IsLower)) {
            return true;
        }

        // Validando se apenas a primeira letra é maiúscula e o restante é minúscula
        return char.IsUpper(word[0]) && word.Skip(1).All(char.IsLower);
    }
}
```


public class Solution {
    public bool DetectCapitalUse(string word) {
        // Validando se todas as letras são maiúsculas ou minúsculas
        if (word.All(char.IsUpper) || word.All(char.IsLower)) {
            return true;
        }

        // Validando se apenas a primeira letra é maiúscula e o restante é minúscula
        return char.IsUpper(word[0]) && word.Skip(1).All(char.IsLower);
    }
    
}


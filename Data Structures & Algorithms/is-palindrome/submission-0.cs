public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                sb.Append(char.ToLower(c));
            }
        }
        string t = sb.ToString();
        for(int i = 0; i<(t.Length)/2;i++){
            if(t[i] != t[t.Length-(i+1)]){
                return false;
            }
        }
        return true;
    }
}

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        } 
        string sorteds = new string(s.OrderBy(c => char.ToLower(c)).ThenBy(c=>c).ToArray()); 
string sortedt = new string(t.OrderBy(c => char.ToLower(c)).ThenBy(c =>c ).ToArray());
if(sorteds != sortedt){
        return false;
    }
    else{
        return true;
    }
    }
    
}

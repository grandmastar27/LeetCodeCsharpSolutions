using System.Linq;
public class Solution {
    public char FindTheDifference(string s, string t) {
       	var charS = s.ToCharArray().ToList();
        var charT = t.ToCharArray().ToList();
        return t.Except(s).First();
    }
}
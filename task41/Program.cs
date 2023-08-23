
// посложнее решил придумать)
string s = "0, 7, 8, a, G,  -2, -2,YES,  9  ";

Console.WriteLine(GetPositiveNum(s));
int GetPositiveNum(string s){
    string[] GetNumS = s.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int count = 0;
    foreach(string n in GetNumS){
        bool tryN = int.TryParse(n, out int num);
        if(tryN){
            if(num > 0){
                count++;
            }
        }
    }
    return count;
}



// string s = "0, 7, 8, -2, -2";

// Console.WriteLine($"{String.Join(", ", GetPositiveNum(s))}");

// int GetPositiveNum(string s){
//     string[] GetNumS = s.Split(',', StringSplitOptions.RemoveEmptyEntries);
//     int count = 0;
//     foreach(string i in GetNumS){
//         int n = Convert.ToInt32(i);
//         if(n > 0){
//             count++;
//         }
//     }
//     return count;
// }
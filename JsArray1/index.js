var regemler = [4, 6, 9, 12, 24];
var cem = regemler [0];
for (var i = 0; i < regemler.Length; i++)
{
    if (regemler[i] > 0 && regemler[i] % 6 == 0) {
        console.log(regemler[i]);
        cem = cem + regemler[i]
    }
}
console.log(" cemi :" + cem);

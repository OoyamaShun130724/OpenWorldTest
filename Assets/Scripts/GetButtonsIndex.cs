using UnityEngine;

//インベントリの何番目のボタンが押されたかの数値を各ボタンに持たせる
public class GetButtonsIndex : MonoBehaviour
{
    public int _ind = -1;
    public int _cost = -1;
    public int returnindex()
    {
        return _ind;
    }
    public int returncost()
    {
        return _cost;
    }
}

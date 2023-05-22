using UnityEngine;

//データベースの何番目のアイテムのボタンが押されたか判定する
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

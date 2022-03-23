using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BeverageParamsSO : ScriptableObject
{
    [Header("飲み物の値段")]
    [SerializeField]
    private float _espressoCost;
    public float EspressoCost
    {
        get { return _espressoCost; }
        set { _espressoCost = value; }
    }

    [SerializeField]
    private float _darkRoastCost;
    public float DarkRoastCost
    {
        get { return _darkRoastCost; }
        set { _darkRoastCost = value; }
    }

    [SerializeField]
    private float _houseBlendCost;
    public float HouseBlendCost
    {
        get { return _houseBlendCost; }
        set { _houseBlendCost = value; }
    }

    [Header("トッピングの値段(Grandeサイズ基準)")]
    [SerializeField]
    private float _whipCost;
    public float WhipCost
    {
        get { return _whipCost; }
        set { _whipCost = value; }
    }

    [SerializeField]
    private float _mochaCost;
    public float MochaCost
    {
        get { return _mochaCost; }
        set { _mochaCost = value; }
    }

    [SerializeField]
    private float _soyCost;
    public float SoyCost
    {
        get { return _soyCost; }
        set { _soyCost = value; }
    }

    [Header("サイズ変更で増加/減少する値段")]
    [SerializeField]
    private float _additionalCost;
    public float AdditionalCost
    {
        get { return _additionalCost; }
        set { _additionalCost = value; }
    }

    [SerializeField]
    private float _reducedCost;
    public float ReducedCost
    {
        get { return _reducedCost; }
        set { _reducedCost = value; }
    }

    //MyScriptableObjectが保存してある場所のパス
    public const string PATH = "BeverageParamsSO";

    //MyScriptableObjectの実体
    private static BeverageParamsSO _entity;
    public static BeverageParamsSO Entity
    {
        get
        {
            //初アクセス時にロードする
            if (_entity == null)
            {
                _entity = Resources.Load<BeverageParamsSO>(PATH);

                //ロード出来なかった場合はエラーログを表示
                if (_entity == null)
                {
                    Debug.LogError(PATH + " not found");
                }
            }

            return _entity;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;//Satýn alma iþlemini yapabilmek icin

public class IAPKodlar : MonoBehaviour
{
    private string coin500 = "com.ZeynepSebnem.IAPAzKodlu.coin500";
    private string removeads = "com.ZeynepSebnem.IAPAzKodlu.removeads";
    public GameObject restoreButton;
    public void Awake()
    {
        if (Application.platform != RuntimePlatform.IPhonePlayer)
        {
            restoreButton.SetActive(false);
        }
    }
    public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id == coin500)
        {
            Debug.Log("500 altin satin alindi");
        }
        if (product.definition.id == removeads)
        {
            Debug.Log("Reklam kaldirma satin alindi");
        }
    }
    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(product.definition.id + " hata nedir : " + failureReason);
    }
}

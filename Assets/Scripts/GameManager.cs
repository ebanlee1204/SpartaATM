using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I;
    static double cash = 100000;
    static double balance = 50000;

    public Text text_cash;
    public Text text_balance;

    public GameObject Warning;

    [SerializeField] InputField inputField;

    private void Awake()
    {
        I = this;
    }

    // Update is called once per frame
    void Update()
    {
        text_cash.text = cash.ToString();
        text_balance.text = balance.ToString();
    }

    public void Deposit10000()
    {
        if(cash < 10000)
        {
            Warning.SetActive(true);
            return;
        }

        cash -= 10000;
        balance += 10000;
    }

    public void Deposit30000()
    {
        if (cash < 30000)
        {
            Warning.SetActive(true);
            return;
        }

        cash -= 30000;
        balance += 30000;
    }

    public void Deposit50000()
    {
        if (cash < 50000)
        {
            Warning.SetActive(true);
            return;
        }

        cash -= 50000;
        balance += 50000;
    }

    public void DepositManual()
    {
        int tmp = int.Parse(inputField.text);

        if (cash < tmp)
        {
            Warning.SetActive(true);
            return;
        }

        cash -= tmp;
        balance += tmp;
    }

    public void Withdraw10000()
    {
        if (balance < 10000)
        {
            Warning.SetActive(true);
            return;
        }

        cash += 10000;
        balance -= 10000;
    }
    public void Withdraw30000()
    {
        if (balance < 30000)
        {
            Warning.SetActive(true);
            return;
        }

        cash += 30000;
        balance -= 30000;
    }

    public void Withdraw50000()
    {
        if (balance < 50000)
        {
            Warning.SetActive(true);
            return;
        }

        cash += 50000;
        balance -= 50000;
    }

    public void WithdrawManual()
    {
        int tmp = int.Parse(inputField.text);

        if (balance < tmp)
        {
            Warning.SetActive(true);
            return;
        }

        cash += tmp;
        balance -= tmp;
    }

    public void OKBtn()
    {
        Warning.SetActive(false);
    }
}

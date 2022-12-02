using UnityEngine;
using TMPro;

public class FireBallAmeliorations : MonoBehaviour
{
    public FireBallScript fireBallScript;
    public ScoreScript scoreScript;
    public PlayerCompetences playerCompetences;

    //Fireball Speed Amelioration
    public TextMeshProUGUI fireballSpeedCostText;
    public TextMeshProUGUI fireballSpeedlevelText;
    public int fireballSpeedCost;
    public int fireballSpeedlevel;

    //Fireball Fire Rate Amelioration
    public TextMeshProUGUI fireballFireRateCostText;
    public TextMeshProUGUI fireballFireRatelevelText;
    public int fireballFireRateCost;
    public int fireballFireRatelevel;

    //Fireball Damages Amelioration
    public TextMeshProUGUI fireballDamagesCostText;
    public TextMeshProUGUI fireballDamageslevelText;
    public int fireballDamagesCost;
    public int fireballDamageslevel;

    void Start()
    {
        fireballStats();
    }

    public void fireballStats()
    {
        fireBallScript.force = 10;
        playerCompetences.fireRate = 0.5f;
        fireBallScript.damages = 5;


        fireballSpeedCost = 300;
        fireballSpeedCostText.text = fireballSpeedCost.ToString();
        fireballSpeedlevel = 1;
        fireballSpeedlevelText.text = fireballSpeedlevel.ToString();

        fireballFireRateCost = 300;
        fireballFireRateCostText.text = fireballFireRateCost.ToString();
        fireballFireRatelevel = 1;
        fireballFireRatelevelText.text = fireballFireRatelevel.ToString();

        fireballDamagesCost = 300;
        fireballDamagesCostText.text = fireballDamagesCost.ToString();
        fireballDamageslevel = 1;
        fireballDamageslevelText.text = fireballDamageslevel.ToString();
    }

    public void fireballSpeedAmeliorations()
    {
        if (fireballSpeedlevel == 1 && scoreScript.score > fireballSpeedCost)
        {
            scoreScript.score -= fireballSpeedCost;
            fireBallScript.force += 2;

            fireballSpeedCost = 500;
            fireballSpeedCostText.text = fireballSpeedCost.ToString();

            fireballSpeedlevel = 2;
            fireballSpeedlevelText.text = fireballSpeedlevel.ToString();
        }

        if (fireballSpeedlevel == 2 && scoreScript.score > fireballSpeedCost)
        {
            scoreScript.score -= fireballSpeedCost;
            fireBallScript.force += 2;

            fireballSpeedCost = 700;
            fireballSpeedCostText.text = fireballSpeedCost.ToString();

            fireballSpeedlevel = 3;
            fireballSpeedlevelText.text = fireballSpeedlevel.ToString();
        }

        if (fireballSpeedlevel == 3 && scoreScript.score > fireballSpeedCost)
        {
            scoreScript.score -= fireballSpeedCost;
            fireBallScript.force += 2;

            fireballSpeedCost = 1000;
            fireballSpeedCostText.text = fireballSpeedCost.ToString();

            fireballSpeedlevel = 4;
            fireballSpeedlevelText.text = fireballSpeedlevel.ToString();
        }

        if (fireballSpeedlevel == 4 && scoreScript.score > fireballSpeedCost)
        {
            scoreScript.score -= fireballSpeedCost;
            fireBallScript.force += 2;

            fireballSpeedCost = 1500;
            fireballSpeedCostText.text = fireballSpeedCost.ToString();

            fireballSpeedlevel = 5;
            fireballSpeedlevelText.text = fireballSpeedlevel.ToString();
        }
    }

    public void fireballFireRateAmeliorations()
    {
        if (fireballFireRatelevel == 1 && scoreScript.score > fireballFireRateCost)
        {
            scoreScript.score -= fireballFireRateCost;
            playerCompetences.fireRate -= 0.03f;

            fireballFireRateCost = 500;
            fireballFireRateCostText.text = fireballFireRateCost.ToString();

            fireballFireRatelevel = 2;
            fireballFireRatelevelText.text = fireballFireRatelevel.ToString();
        }

        if (fireballFireRatelevel == 2 && scoreScript.score > fireballFireRateCost)
        {
            scoreScript.score -= fireballFireRateCost;
            playerCompetences.fireRate -= 0.03f;

            fireballFireRateCost = 700;
            fireballFireRateCostText.text = fireballFireRateCost.ToString();

            fireballFireRatelevel = 3;
            fireballFireRatelevelText.text = fireballFireRatelevel.ToString();
        }

        if (fireballFireRatelevel == 3 && scoreScript.score > fireballFireRateCost)
        {
            scoreScript.score -= fireballFireRateCost;
            playerCompetences.fireRate -= 0.03f;

            fireballFireRateCost = 1000;
            fireballFireRateCostText.text = fireballFireRateCost.ToString();

            fireballFireRatelevel = 4;
            fireballFireRatelevelText.text = fireballFireRatelevel.ToString();
        }

        if (fireballFireRatelevel == 4 && scoreScript.score > fireballFireRateCost)
        {
            scoreScript.score -= fireballFireRateCost;
            playerCompetences.fireRate -= 0.03f;

            fireballFireRateCost = 1500;
            fireballFireRateCostText.text = fireballFireRateCost.ToString();

            fireballFireRatelevel = 5;
            fireballFireRatelevelText.text = fireballFireRatelevel.ToString();
        }
    }

    public void fireballDamageAmeliorations()
    {
        if (fireballDamageslevel == 1 && scoreScript.score > fireballDamagesCost)
        {
            scoreScript.score -= fireballDamagesCost;
            fireBallScript.damages += 2;

            fireballDamagesCost = 500;
            fireballDamagesCostText.text = fireballDamagesCost.ToString();

            fireballDamageslevel = 2;
            fireballDamageslevelText.text = fireballDamageslevel.ToString();
        }

        if (fireballDamageslevel == 2 && scoreScript.score > fireballDamagesCost)
        {
            scoreScript.score -= fireballDamagesCost;
            fireBallScript.damages += 2;

            fireballDamagesCost = 700;
            fireballDamagesCostText.text = fireballDamagesCost.ToString();

            fireballDamageslevel = 3;
            fireballDamageslevelText.text = fireballDamageslevel.ToString();
        }

        if (fireballDamageslevel == 3 && scoreScript.score > fireballDamagesCost)
        {
            scoreScript.score -= fireballDamagesCost;
            fireBallScript.damages += 2;

            fireballDamagesCost = 1000;
            fireballDamagesCostText.text = fireballDamagesCost.ToString();

            fireballDamageslevel = 4;
            fireballDamageslevelText.text = fireballDamageslevel.ToString();
        }

        if (fireballDamageslevel == 4 && scoreScript.score > fireballDamagesCost)
        {
            scoreScript.score -= fireballDamagesCost;
            fireBallScript.damages += 2;

            fireballDamagesCost = 1500;
            fireballDamagesCostText.text = fireballDamagesCost.ToString();

            fireballDamageslevel = 5;
            fireballDamageslevelText.text = fireballDamageslevel.ToString();
        }
    }
}

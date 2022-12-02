using UnityEngine;
using TMPro;

public class GatlingAmeliorations : MonoBehaviour
{
    public GatlingModeScript gatlingModeScript;
    public ScoreScript scoreScript;
    public PlayerFirePower playerFirePower;

    //Gatling Mode Bullets Speed Amelioration
    public TextMeshProUGUI bulletSpeedCostText;
    public TextMeshProUGUI bulletSpeedlevelText;
    public int bulletSpeedCost;
    public int bulletSpeedlevel;

    //Gatling Mode Bullets More Storage Amelioration
    public TextMeshProUGUI moreStorageCostText;
    public TextMeshProUGUI moreStoragelevelText;
    public int moreStorageCost;
    public int moreStoragelevel;

    //Gatling Mode Bullets Damages Amelioration
    public TextMeshProUGUI bulletDamagesCostText;
    public TextMeshProUGUI bulletlDamageslevelText;
    public int bulletDamagesCost;
    public int bulletDamageslevel;

    void Start()
    {
        gatlingModeBulletStats();
    }

    public void gatlingModeBulletStats()
    {
        gatlingModeScript.force = 10;
        playerFirePower.maxGatlingBullet = 600;
        gatlingModeScript.damages = 5;


        bulletSpeedCost = 300;
        bulletSpeedCostText.text = bulletSpeedCost.ToString();
        bulletSpeedlevel = 1;
        bulletSpeedlevelText.text = bulletSpeedlevel.ToString();

        moreStorageCost = 300;
        moreStorageCostText.text = moreStorageCost.ToString();
        moreStoragelevel = 1;
        moreStoragelevelText.text = moreStoragelevel.ToString();

        bulletDamagesCost = 300;
        bulletDamagesCostText.text = bulletDamagesCost.ToString();
        bulletDamageslevel = 1;
        bulletlDamageslevelText.text = bulletDamageslevel.ToString();
    }

    public void bulletSpeedAmeliorations()
    {
        if (bulletSpeedlevel == 1 && scoreScript.score > bulletSpeedCost)
        {
            scoreScript.score -= bulletSpeedCost;
            gatlingModeScript.force += 1;

            bulletSpeedCost = 500;
            bulletSpeedCostText.text = bulletSpeedCost.ToString();

            bulletSpeedlevel = 2;
            bulletSpeedlevelText.text = bulletSpeedlevel.ToString();
        }

        if (bulletSpeedlevel == 2 && scoreScript.score > bulletSpeedCost)
        {
            scoreScript.score -= bulletSpeedCost;
            gatlingModeScript.force += 1;

            bulletSpeedCost = 700;
            bulletSpeedCostText.text = bulletSpeedCost.ToString();

            bulletSpeedlevel = 3;
            bulletSpeedlevelText.text = bulletSpeedlevel.ToString();
        }

        if (bulletSpeedlevel == 3 && scoreScript.score > bulletSpeedCost)
        {
            scoreScript.score -= bulletSpeedCost;
            gatlingModeScript.force += 1;

            bulletSpeedCost = 1000;
            bulletSpeedCostText.text = bulletSpeedCost.ToString();

            bulletSpeedlevel = 4;
            bulletSpeedlevelText.text = bulletSpeedlevel.ToString();
        }

        if (bulletSpeedlevel == 4 && scoreScript.score > bulletSpeedCost)
        {
            scoreScript.score -= bulletSpeedCost;
            gatlingModeScript.force += 1;

            bulletSpeedCost = 1500;
            bulletSpeedCostText.text = bulletSpeedCost.ToString();

            bulletSpeedlevel = 5;
            bulletSpeedlevelText.text = bulletSpeedlevel.ToString();
        }
    }

    public void bulletMoreStorageAmeliorations()
    {
        if (moreStoragelevel == 1 && scoreScript.score > moreStorageCost)
        {
            scoreScript.score -= moreStorageCost;
            playerFirePower.maxGatlingBullet += 50;

            moreStorageCost = 500;
            moreStorageCostText.text = moreStorageCost.ToString();

            moreStoragelevel = 2;
            moreStoragelevelText.text = moreStoragelevel.ToString();
        }

        if (moreStoragelevel == 2 && scoreScript.score > moreStorageCost)
        {
            scoreScript.score -= moreStorageCost;
            playerFirePower.maxGatlingBullet += 50;

            moreStorageCost = 700;
            moreStorageCostText.text = moreStorageCost.ToString();

            moreStoragelevel = 3;
            moreStoragelevelText.text = moreStoragelevel.ToString();
        }

        if (moreStoragelevel == 3 && scoreScript.score > moreStorageCost)
        {
            scoreScript.score -= moreStorageCost;
            playerFirePower.maxGatlingBullet += 50;

            moreStorageCost = 1000;
            moreStorageCostText.text = moreStorageCost.ToString();

            moreStoragelevel = 4;
            moreStoragelevelText.text = moreStoragelevel.ToString();
        }

        if (moreStoragelevel == 4 && scoreScript.score > moreStorageCost)
        {
            scoreScript.score -= moreStorageCost;
            playerFirePower.maxGatlingBullet += 50;

            moreStorageCost = 1500;
            moreStorageCostText.text = moreStorageCost.ToString();

            moreStoragelevel = 5;
            moreStoragelevelText.text = moreStoragelevel.ToString();
        }
    }

    public void bulletDamageAmeliorations()
    {
        if (bulletDamageslevel == 1 && scoreScript.score > bulletDamagesCost)
        {
            scoreScript.score -= bulletDamagesCost;
            gatlingModeScript.damages += 1;

            bulletDamagesCost = 500;
            bulletDamagesCostText.text = bulletDamagesCost.ToString();

            bulletDamageslevel = 2;
            bulletlDamageslevelText.text = bulletDamageslevel.ToString();
        }

        if (bulletDamageslevel == 2 && scoreScript.score > bulletDamagesCost)
        {
            scoreScript.score -= bulletDamagesCost;
            gatlingModeScript.damages += 1;

            bulletDamagesCost = 700;
            bulletDamagesCostText.text = bulletDamagesCost.ToString();

            bulletDamageslevel = 3;
            bulletlDamageslevelText.text = bulletDamageslevel.ToString();
        }

        if (bulletDamageslevel == 3 && scoreScript.score > bulletDamagesCost)
        {
            scoreScript.score -= bulletDamagesCost;
            gatlingModeScript.damages += 1;

            bulletDamagesCost = 1000;
            bulletDamagesCostText.text = bulletDamagesCost.ToString();

            bulletDamageslevel = 4;
            bulletlDamageslevelText.text = bulletDamageslevel.ToString();
        }

        if (bulletDamageslevel == 4 && scoreScript.score > bulletDamagesCost)
        {
            scoreScript.score -= bulletDamagesCost;
            gatlingModeScript.damages += 1;

            bulletDamagesCost = 1500;
            bulletDamagesCostText.text = bulletDamagesCost.ToString();

            bulletDamageslevel = 5;
            bulletlDamageslevelText.text = bulletDamageslevel.ToString();
        }
    }
}

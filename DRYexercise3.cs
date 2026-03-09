    int health= 100;

    void Hasar(string dmgtype,int miktar)
    {
        health-=miktar;
        if (health<0) health=0;
    }
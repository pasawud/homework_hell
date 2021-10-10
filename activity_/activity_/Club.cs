using System;
using System.Collections.Generic;

class club
{
    public string clubs;
    public club(string valueclub)
    {
        clubs = valueclub;

    }
}
class clubList
{
    private List<club> clubsList;

    public clubList()
    {
        this.clubsList = new List<club>();
    }
    public void Addclub(club Club)
    {
        this.clubsList.Add(Club);
    }
}
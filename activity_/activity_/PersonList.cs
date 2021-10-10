using System;
using System.Collections.Generic;


class PersonList
{
    private List<Person> personList;

    public PersonList()
    {
        this.personList = new List<Person>();
    }
    public void AddPerson(Person person)
    {
        this.personList.Add(person);
    }
}
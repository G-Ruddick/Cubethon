using UnityEngine;
using System.Collections;

public abstract class Subject : MonoBehaviour {
    private readonly ArrayList observerList = new ArrayList();

    public void Attach(Observer observer) {
        observerList.Add(observer);
    }

    public void Detach(Observer observer) {
        observerList.Remove(observer);
    }

    public void NotifyObservers() {
        foreach (Observer observer in observerList) {
            observer.Notify(this);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITSubject {

	List<ITObserver> observers{ get; }

	void notify();

	void addObserver(ITObserver observer);

	void removeObserver(ITObserver observer);
}

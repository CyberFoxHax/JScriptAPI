class Enumerator {
	public Enumerator(IEnumerable collection);
	bool atEnd();
	void moveNext();
	T item();
}
#include <iostream> 
#include <string>
#include <clocale>

using namespace std;

//_______________________________ÊËÀÑÑ_______________________________\\
ÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌ
template <class T, class  F>
class Voice
{
private:
	T modelNumber;
	F power;
	char* name;
	bool unit;

public:
	Voice();

	Voice(T a, F b, char* c, bool d);
	Voice(const Voice<T, F>& a);
	~Voice();
	void Info();
	Voice <T, F> sum(const Voice<T, F>& a);
	bool Cmp(const Voice<T, F>& a);
	void Copy(const Voice<T, F>& a);

	Voice<T, F>operator =(const  Voice<T, F>& a);
	Voice<T, F>operator +(const  Voice<T, F>& a);

	bool operator >(const  Voice<T, F>& a);
	bool operator <(const  Voice<T, F>& a);
	bool operator ==(const  Voice<T, F>& a);
	bool operator !=(const  Voice<T, F>& a);
	bool operator >=(const  Voice<T, F>& a);
	bool operator <=(const  Voice<T, F>& a);

};

template <class T, class F>
void Voice<T, F> ::Info()
{
	cout << "Íàçâàíèå: " << name;
	cout << "Íîìåğ ìîäåëè çâóêîâîãî óñòğîéñòâà: " << modelNumber << endl;
	cout << "Ìîùíîñòü: " << power << "ó.å." << endl;
	if (unit)
	{
		cout << "Óëó÷øåííîå óñòğîéñòâî";
	}
	else
	{
		cout << "Ñòîêîâîå óñòğîéñòâî";
	}
	cout << endl;

}

template <class T, class F>
Voice<T, F> ::Voice()
{
	modelNumber = (T)0;
	power = (F)0;
	unit = false;
	name = new char[1];
	strcpy(name, "");
}

template <class T, class F>
Voice<T, F> ::Voice(T t, F f, char* n, bool u)
{
	modelNumber = (T)t;
	power = (F)f;
	unit = u;
	name = new char[strlen(n) + 1];
	strcpy(name, n);
}

template <class T, class F>
Voice<T, F> ::Voice(const Voice<T, F>& v)
{
	if (&v != this)
	{
		modelNumber = v.modelNumber;
		power = v.power;
		name = new char[strlen(v.name) + 1];
		strcpy(name, v.name);
		unit = v.unit;
	}
}

template <class T, class F>
Voice<T, F> ::~Voice()
{
	delete[] name;
}


template <class T, class F>
bool Voice<T, F> ::Cmp(const Voice<T, F>& a)
{
	if (power == a.power && modelNumber == a.modelNumber && unit == a.unit && name == a.name)
		return true;
	else
		return false;
}


template <class T, class F>
void Voice<T, F> ::Copy(const Voice<T, F>& a)
{
	modelNumber = a.modelNumber;
	power = a.power;
	name = new char[strlen(a.name) + 1];
	strcpy(name, a.name);
	unit = a.unit;
}

template <class T, class F>
Voice<T, F> Voice<T, F> ::sum(const Voice<T, F>& a)
{
	Voice<T, F> f;
	char* tmp = new char[strlen(name) + 1];
	strcpy(tmp, name);
	f.modelNumber = modelNumber + a.modelNumber;
	f.power = power + a.power;
	f.unit = unit + a.unit;
	strcat(tmp, "-");
	strcat(tmp, a.name);
	f.name = new char[strlen(tmp) + 1];
	strcpy(f.name, tmp);
	return f;
}

template <class T, class F>
Voice<T, F> Voice<T, F> :: operator=(const Voice<T, F>& a)
{
	if (this == &a)  return *this;
	else
	{
		this->Copy(a);
		return *this;
	}
}

template <class T, class F>
Voice<T, F> Voice<T, F> :: operator+(const Voice<T, F>& a)
{
	Voice f = this->sum(a);
	return f;
}


template <class T, class F>
bool Voice<T, F> :: operator<(const Voice<T, F>& a)
{
	return power < a.power && modelNumber < a.modelNumber;
}

template <class T, class F>
bool Voice<T, F> :: operator>(const Voice<T, F>& a)
{
	return power > a.power&& modelNumber > a.modelNumber;
}

template <class T, class F>
bool Voice<T, F> :: operator==(const Voice<T, F>& a)
{
	return power == a.power && modelNumber == a.modelNumber && name == a.name && unit == a.unit;
}

template <class T, class F>
bool Voice<T, F> :: operator!=(const Voice<T, F>& a)
{
	return power != a.power || modelNumber != a.modelNumber || name != a.name || unit == a.unit;
}

template <class T, class F>
bool Voice<T, F> :: operator<=(const Voice<T, F>& a)
{
	return (power < a.power && modelNumber < a.modelNumber) || (power != a.power || modelNumber != a.modelNumber || name != a.name || unit == a.unit);
}

template <class T, class F>
bool Voice<T, F> :: operator>=(const Voice<T, F>& a)
{
	return (power > a.power&& modelNumber > a.modelNumber) || (power != a.power || modelNumber != a.modelNumber || name != a.name || unit == a.unit);
}

//________________________íàñëåäîâàíèå________________________\\
ÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌÌ
template <class T>
class Pillow
{
protected:
	T soft;
	char* color;
public:
	Pillow();
	Pillow(T s, char* c);
	~Pillow();

	void virtual print();
	void refill();
	void use();
};

template <class T>
Pillow<T>::Pillow()
{
	soft = (T)0;
	color = new char[7];
	strcpy(color, "white");
}

template <class T>
Pillow<T>::Pillow(T s, char* c)
{
	soft = (T)s;
	color = new char[strlen(c) + 1];
	strcpy(color, c);
}

template <class T>
Pillow<T> ::~Pillow()
{
	soft = (T)0;
	//color = (char*)"";
	delete[] color;
}

template <class T>
void Pillow<T>::print()
{
	cout << "Ìÿãêîñòü: " << soft << endl;
	cout << "Öâåò: " << color << endl << endl;
}

template <class T>
void Pillow<T> ::refill()
{
	soft += (T)1;
}

template <class T>
void Pillow<T>::use()
{
	if (soft != (T)0)
	{
		soft -= (T)1;
	}
}

//________________________________íàñëåäóåì________________________________\\
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMÌ
template <class T>
class Next : Pillow<T>
{
private:
	double noiseDown;
public:
	void virtual print();
	Next();
	void refill();
	void use();
	Next(T s, char* c, double r);
	void speedUp();
};

template <class T>
void Next<T>::refill()
{
	Pillow<T>::refill();
}

template <class T>
void Next<T>::use()
{
	Pillow::use();
}

template <class T>
Next<T>::Next(T s, char* c, double r) : Pillow<T>::Pillow(s, c)
{
	noiseDown = r;
}

template <class T>
Next<T>::Next() : Pillow<T>::Pillow()
{
	noiseDown = 1;
}

template <class T>
void Next<T>::print()
{
	Pillow<T>::print();
	cout << "Øóìîèçîëÿöèÿ: " << noiseDown << endl << endl;
}

template <class T>
void Next<T>::speedUp()
{
	noiseDown += 10;
}


//________________________________DO_IT________________________________\\
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMÌ
int main()
{
	setlocale(LC_ALL, "rus");
	Pillow<int> pill(), pillow(15, (char*)"white");
	Next<int> next1(), next2(20, (char*)"another", 0.5);
	pillow.print();
	next2.print();
	next2.refill();
	next2.speedUp();
	next2.print();
	system("pause");
	return 0;
}

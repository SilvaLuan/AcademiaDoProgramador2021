#include <iostream>

using namespace std;

/*Academia do programador

Eu tentei desenvolver a aplicação que foi pedida mas não deu muito certo, então escrevi esse código em c++ pra não ficar sem entregar nada.
Sinto muito mas não consegui desenvolver a aplicação*/

int main(){

string nome, fabricante;
double preco_aq;
int numero_s;


cout<<"Nome do equipamento a ser adicionado:";
cin>>nome;

	while(nome != "fim"){

		cout<<"\nNome do fabricante:";
		cin>>fabricante;

		cout<<"\nPreco de aquisicao:";
		cin>>preco_aq;

		cout<<"\nNumero de serie do produto:";
		cin>>numero_s;

		cout<<"\nNome do equipamento a ser adicionado:";
		cin>>nome;	
	}
	
	cout<<"Produto:"<< nome << "\n";
	cout<<"Fabricante:"<< fabricante << "\n";
	cout<<"Preco de aquisicao:"<< preco_aq << "\n";
	cout<<"Numero de serie:"<< numero_s << "\n";
		
	return 0;
} 

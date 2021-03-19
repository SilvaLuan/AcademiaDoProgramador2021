#include <iostream>
#include <locale.h>
using namespace std;
/*Eu não consegui desenvolver o resto da aplicação */
int main(){
	setlocale(LC_ALL,"Portuguese");
	
	string equipamentos[99], fabricantes[99];
	double precos[99];
	int i=0, tam, numeros[99] ;
	bool loop=true;
	
	while(loop==true){
		
		cout<<"Digite o nome do equipamento ou Fim para concluir a entrada de dados: ";
		cin>>equipamentos[i];
		
		if(equipamentos[i]!="FIM"){
			cout<<"Digite o nome do fabricante:";
			cin>>fabricantes[i];
			
			cout<<"Digite o preco de aquisicao do produto: ";
			cin>>precos[i];
			
			cout<<"Digite o numero de serie do produto: ";
			cin>>numeros[i];
			
			i++;
		    tam=i;		
		}
		
		if(equipamentos[i]=="FIM"){
			loop=false;
			break;
		}		
	}
	cout<<"\nEquipamento:";
	cin>>equipamentos[i];
	
	cout<<"\nFabricante";
	cin>>fabricantes[i];
	
	cout<<"\nPreco de aquisicao";
	cin>>precos[i];
	
	cout<<"\nNumero de serie:";
	cin>>numeros[i];


}

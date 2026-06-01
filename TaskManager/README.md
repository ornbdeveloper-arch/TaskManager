_# 🛠️ TaskManager - V1.0.2

O projeto surgiu como um meio para aprender a linguagem C# e sua intenção é que continue sendo atualizado conforme meus estudos com a linguagem avancem.

---

## 📈 Histórico de Evolução

### 🔹 Detalhes da V1.0.0
No início, usei um esquema de listas para armazenar os dados dos chamados: uma lista para o **ID** e outra para o **corpo dos chamados**.
A conexão entre eles era feita pelo índice das duas listas. Portanto, o ID 1 que ficava no índice `0` era conectado ao chamado que também estava no índice `0` da outra lista.

### 🔹 Detalhes da V1.0.1
Aqui já comecei a aplicar conceitos de Orientação a Objetos e usei **classes** para armazenar as informações.  
Criei a classe `Chamado`, onde centralizei os atributos dos chamados e o método de adição.

### 🔹 Detalhes da V1.0.2 
Nesta versão, adicionei mais atributos aos chamados, dando mais identidade a eles. Além disso:
- Comentei todos os trechos importantes da aplicação para testar e fixar a sintaxe da linguagem.
- Criei este arquivo `README.md`, aplicando um novo aprendizado sobre documentação diretamente no repositório do app._
### 🔹 Detalhes da V1.0.3 
Nesta versão, foram adicionadas novas classes para usuários, sla, e cartegorias de chamados, nem todas estão em uso no momento, faltando apenas implementação no código principal.
- Foi removido a escrita da prioridade, naõ sendo mais um texto alterável e sim um item pré definido com tempo estipulado.
### 🔹 Detalhes da V1.0.4 *(Versão Atual)*
- Nova classe DadosDoSistema adicionada.
- Listas pré-populadas removidas do código Main para serem executadas diretamente na classe.
- Validação de preenchimentos dos dados que precisam vir do usuário.
- Encapsulamento dos atributodos das classes já criadas.
- Indexação do SLA com base na categoria do chamado.
- Adição da escolha de categoria durante a criação do chamado.

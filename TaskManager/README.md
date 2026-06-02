# 🛠️ TaskManager - V1.0.5

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
- Criei este arquivo `README.md`, aplicando um novo aprendizado sobre documentação diretamente no repositório do app.

### 🔹 Detalhes da V1.0.3
Nesta versão, foram adicionadas novas classes para usuários, SLA e categorias de chamados, nem todas estavam em uso no momento, faltando apenas implementação no código principal.
- Foi removida a escrita da prioridade, não sendo mais um texto alterável e sim um item pré-definido com tempo estipulado.

### 🔹 Detalhes da V1.0.4
- Nova classe `DadosDoSistema` adicionada.
- Listas pré-populadas removidas do código `Main` para serem executadas diretamente na classe.
- Validação de preenchimento dos dados que precisam vir do usuário.
- Encapsulamento dos atributos das classes já criadas.
- Indexação do SLA com base na categoria do chamado.
- Adição da escolha de categoria durante a criação do chamado.

### 🔹 Detalhes da V1.0.5 *(Versão Atual)*
Versão focada em consolidar boas práticas de Orientação a Objetos e introduzir novos conceitos da linguagem C#.

- **Encapsulamento aprofundado:** atributos protegidos com `private set` em todas as classes, impedindo alterações externas indevidas.
- **Validações no construtor:** uso de `throw new ArgumentException` para garantir que nenhum objeto seja criado com dados inválidos, substituindo os `Console.WriteLine` silenciosos anteriores.
- **Enum `StatusChamado`:** adicionado para representar os estados possíveis de um chamado (`Aberto`, `EmAndamento`, `Fechado`) de forma segura, eliminando o uso de strings soltas.
- **Métodos de transição de status:** criados `IniciarAtendimento()` e `FecharChamado()` na classe `Chamado`, aplicando regras de negócio diretamente na classe responsável.
- **Novas opções no menu:** o sistema agora permite iniciar e fechar chamados pelo ID diretamente no terminal.
- **Vínculo Categoria/SLA:** cada categoria agora carrega seu próprio SLA, tornando impossível criar um chamado com categoria e SLA desvinculados.
- **Campo `Contrato`:** adicionado à classe `Chamado`, preenchido pelo usuário na criação.
- **Herança introduzida:** criada a classe `ChamadoFrota`, que herda de `Chamado` e adiciona atributos específicos do setor de Frota (`Combustivel`, `Motorista`, `Unidade`, `Placa`, `KM`), preparando o sistema para suportar múltiplos setores.
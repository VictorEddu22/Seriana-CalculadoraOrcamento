# Seriana Calculadora de Orçamento #

## Introdução
Essa Documentação será para a análise e desenvolvimento de um software para cálculos de orçamentos da Gráfica Seriana. Tem como objetivo ajudar o orçamentista a otimizar seu tempo e aproveitar cálculos já feitos de forma que agilize o trabalho e demanda geral. 

### Problema
O Orçamentista é diretamente afetado pelo problema de forma que a uma grande perda de tempo ao fazer os cálculos todos e após feitos ainda revisar se está correto, e com isso acaba afetando ou áreas da venda e pré-produção de diversos serviços, a solução seria criar usar um sistema integrado com a maioria dos setores da empresa para gerir e reduzir o tempo em tarefas muito repetitivas e mal-feitas. 

### Objetivo e Justificativa
O objetivo é criar um sistema para toda a empresa no qual possam melhorar e reduzir o tempo de produção e conseguir ter uma supervisão melhor sobre os processos que se iniciam a um serviço até o final, na sua entrega ao cliente. Inicialmente será projeto um modelo Piloto para testes no dia a dia da empresa, o Piloto será feito para calcular os serviços que possuem mais demanda dentro da empresa, que será o Wobler e a Testeira nas máquinas de impressão digital Mimaki JFX e máquinas de corte Esko e Map Cut.

### Público-Alvo / Quem vai usar?
Público-alvo inicial e principal será o Orçamentista, isso com base no serviço dele e que ele é o encarregado para fazer os cálculos que são feitos a mão que o sistema irá fazer. 

---
## Especificação
Esta seção tem como finalidade apresentar as especificações do sistema de cálculo de orçamento. O objetivo é a definição e análise de elementos que orientam o desenvolvimento da solução especificando requisitos e restrições, a partir da perspectiva do usuário. 

### Requisitos Funcionais (RF) - O que o sistema deve fazer
* RF01: Adicionar nome do serviço e nome do cliente.
* RF02: Verificar se o trabalho já foi feito anteriormente.
* RF03: Mostrar trabalhos feitos com data, cliente, quantidade e preço.
* RF04: Adicionar número da OS.
* RF05: Adicionar tamanho do produto.
* RF06: Adicionar quantidade solicitada.
* RF07: Selecionar material e chapa.
* RF08: Selecionar setor de produção, como impressão e corte.
* RF09: Selecionar máquina ou processo, como Mimaki JFX, Esko ou Map Cut.
* RF10: Fazer cálculo de montagem.
* RF11: Calcular aproveitamento da chapa e quantidade de chapas.
* RF12: Fazer cálculo de Matéria-Prima (aproveitamento da chapa, quantidade de chapas, perda de produção, custo do substrato, tinta, embalagem e demais materiais).
* RF13: Fazer cálculo de Produção (tempo e custo da Mimaki JFX, tempo e custo da Esko ou Map Cut, setup, impressão, corte e acabamento).
* RF14: Fazer cálculo de Serviços Terceiros (frete, faca especial, fotolito/CTP e outros serviços externos).
* RF15: Fazer cálculo de Preço de Venda (preço de custo, custo unitário, margem de lucro, comissões, impostos, taxa de juros, índice de venda, preço total e preço unitário de venda).
* RF16: Salvar e consultar orçamentos feitos.
* RF17: Permitir duplicar orçamento anterior.
* RF18: Gerar PDF do orçamento.
* RF19: Gerar versão interna com custos e versão comercial para o cliente.


---

### Requisitos Não Funcionais (RNF)

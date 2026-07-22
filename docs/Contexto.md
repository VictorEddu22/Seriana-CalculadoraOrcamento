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

### Requisitos Não Funcionais (RNF) - Como o sistema deve fazer
- RNF01: O sistema deve ser simples e intuitivo para o orçamentista.
- RNF02: O sistema deve calcular os valores rapidamente.
- RNF03: O sistema deve garantir precisão nos cálculos de orçamento.
- RNF04: O sistema deve validar campos obrigatórios antes de calcular.
- RNF05: O sistema deve proteger custos, margens e comissões internas.
- RNF06: O sistema deve salvar o histórico dos orçamentos com segurança.
- RNF07: O sistema deve manter os valores originais de cada orçamento salvo.
- RNF08: O sistema deve permitir atualização de materiais, máquinas e percentuais.
- RNF09: O sistema deve gerar PDFs profissionais e legíveis.
- RNF10: O sistema deve funcionar em computadores Windows.
- RNF11: O sistema deve permitir backup dos dados.
- RNF12: O sistema deve estar preparado para futuras integrações e novos serviços gráficos.

---

### Regras de Negócio (RN) - dizem como querm que o sistema funcione.
* RN01: O orçamento deve ter nome do serviço, cliente, quantidade e material selecionado.
* RN02: O sistema deve verificar se já existe orçamento parecido feito anteriormente.
* RN03: Todas as medidas devem ser convertidas para a mesma unidade antes do cálculo.
* RN04: O cálculo de montagem deve considerar tamanho da peça, tamanho da chapa, sangria e abertura.
* RN05: O sistema deve calcular o aproveitamento da chapa na posição normal e girada.
* RN06: O sistema deve escolher automaticamente a montagem com maior aproveitamento.
* RN07: A quantidade de chapas deve sempre ser arredondada para cima.
* RN08: As perdas de produção devem ser adicionadas separadamente das chapas calculadas.
* RN09: O custo da matéria-prima deve considerar chapas, perdas, substrato, tinta, embalagem e demais materiais.
* RN10: O custo de produção deve considerar setup, impressão, corte, acabamento e mão de obra.
* RN11: O custo de terceiros deve considerar frete, faca especial, fotolito/CTP e serviços externos.
* RN12: O preço de custo deve ser calculado pela soma de Matéria-Prima + Produção + Terceiros.
* RN13: O preço de venda deve considerar margem, comissões, impostos e juros.
* RN14: O sistema não deve permitir preço de venda abaixo do custo.
* RN15: A soma de margem, comissões, impostos e juros não pode ser igual ou superior a 100%.
* RN16: O orçamento salvo deve manter os custos usados na data em que foi criado.
* RN17: A versão enviada ao cliente não deve mostrar custo, margem, comissão ou dados internos.
* RN18: Alterações em materiais, custos e percentuais devem afetar apenas novos orçamentos, não os antigos já salvos.

---

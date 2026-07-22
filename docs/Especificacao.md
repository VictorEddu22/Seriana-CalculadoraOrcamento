## Especificação

Esta seção tem como finalidade apresentar as especificações do sistema de cálculo de orçamento. O objetivo é definir e analisar os elementos que orientam o desenvolvimento da solução, especificando requisitos, regras e restrições a partir da perspectiva do usuário.

**Legenda de prioridade:**

| Prioridade | Descrição |
|---|---|
| Alta | Essencial para a primeira versão do sistema. |
| Média | Importante, mas pode ser implementado após o funcionamento principal. |
| Baixa | Desejável para melhorias futuras. |

---

# Requisitos Funcionais (RF) — O que o sistema deve fazer

| Código | Requisito | Prioridade |
|---|---|---|
| RF01 | Adicionar nome do serviço e nome do cliente. | Alta |
| RF02 | Verificar se o trabalho já foi feito anteriormente. | Média |
| RF03 | Mostrar trabalhos feitos com data, cliente, quantidade e preço. | Média |
| RF04 | Adicionar número da OS. | Alta |
| RF05 | Adicionar tamanho do produto. | Alta |
| RF06 | Adicionar quantidade solicitada. | Alta |
| RF07 | Selecionar material e chapa. | Alta |
| RF08 | Selecionar setor de produção, como impressão e corte. | Alta |
| RF09 | Selecionar máquina ou processo, como Mimaki JFX, Esko ou Map Cut. | Alta |
| RF10 | Fazer cálculo de montagem. | Alta |
| RF11 | Calcular aproveitamento da chapa e quantidade de chapas. | Alta |
| RF12 | Fazer cálculo de Matéria-Prima (aproveitamento da chapa, quantidade de chapas, perda de produção, custo do substrato, tinta, embalagem e demais materiais). | Alta |
| RF13 | Fazer cálculo de Produção (tempo e custo da Mimaki JFX, tempo e custo da Esko ou Map Cut, setup, impressão, corte e acabamento). | Alta |
| RF14 | Fazer cálculo de Serviços Terceiros (frete, faca especial, fotolito/CTP e outros serviços externos). | Média |
| RF15 | Fazer cálculo de Preço de Venda (preço de custo, custo unitário, margem de lucro, comissões, impostos, taxa de juros, índice de venda, preço total e preço unitário de venda). | Alta |
| RF16 | Salvar e consultar orçamentos feitos. | Alta |
| RF17 | Permitir duplicar orçamento anterior. | Média |
| RF18 | Gerar PDF do orçamento. | Alta |
| RF19 | Gerar versão interna com custos e versão comercial para o cliente. | Alta |

---

# Requisitos Não Funcionais (RNF) — Como o sistema deve funcionar

| Código | Requisito | Prioridade |
|---|---|---|
| RNF01 | O sistema deve ser simples e intuitivo para o orçamentista. | Alta |
| RNF02 | O sistema deve calcular os valores rapidamente. | Alta |
| RNF03 | O sistema deve garantir precisão nos cálculos de orçamento. | Alta |
| RNF04 | O sistema deve validar campos obrigatórios antes de calcular. | Alta |
| RNF05 | O sistema deve proteger custos, margens e comissões internas. | Alta |
| RNF06 | O sistema deve salvar o histórico dos orçamentos com segurança. | Alta |
| RNF07 | O sistema deve manter os valores originais de cada orçamento salvo. | Alta |
| RNF08 | O sistema deve permitir atualização de materiais, máquinas e percentuais. | Alta |
| RNF09 | O sistema deve gerar PDFs profissionais e legíveis. | Média |
| RNF10 | O sistema deve funcionar em computadores Windows. | Alta |
| RNF11 | O sistema deve permitir backup dos dados. | Alta |
| RNF12 | O sistema deve estar preparado para futuras integrações e novos serviços gráficos. | Baixa |

---

# Regras de Negócio (RN) — Como o processo deve funcionar

| Código | Regra de negócio | Prioridade |
|---|---|---|
| RN01 | O orçamento deve ter nome do serviço, cliente, quantidade e material selecionado. | Alta |
| RN02 | O sistema deve verificar se já existe orçamento parecido feito anteriormente. | Média |
| RN03 | Todas as medidas devem ser convertidas para a mesma unidade antes do cálculo. | Alta |
| RN04 | O cálculo de montagem deve considerar tamanho da peça, tamanho da chapa, sangria e abertura. | Alta |
| RN05 | O sistema deve calcular o aproveitamento da chapa na posição normal e girada. | Alta |
| RN06 | O sistema deve escolher automaticamente a montagem com maior aproveitamento. | Alta |
| RN07 | A quantidade de chapas deve sempre ser arredondada para cima. | Alta |
| RN08 | As perdas de produção devem ser adicionadas separadamente das chapas calculadas. | Alta |
| RN09 | O custo da matéria-prima deve considerar chapas, perdas, substrato, tinta, embalagem e demais materiais. | Alta |
| RN10 | O custo de produção deve considerar setup, impressão, corte, acabamento e mão de obra. | Alta |
| RN11 | O custo de terceiros deve considerar frete, faca especial, fotolito/CTP e serviços externos. | Média |
| RN12 | O preço de custo deve ser calculado pela soma de Matéria-Prima + Produção + Terceiros. | Alta |
| RN13 | O preço de venda deve considerar margem, comissões, impostos e juros. | Alta |
| RN14 | O sistema não deve permitir preço de venda abaixo do custo. | Alta |
| RN15 | A soma de margem, comissões, impostos e juros não pode ser igual ou superior a 100%. | Alta |
| RN16 | O orçamento salvo deve manter os custos usados na data em que foi criado. | Alta |
| RN17 | A versão enviada ao cliente não deve mostrar custo, margem, comissão ou dados internos. | Alta |
| RN18 | Alterações em materiais, custos e percentuais devem afetar apenas novos orçamentos, não os antigos já salvos. | Alta |

## Especificação

Esta seção tem como finalidade apresentar as especificações do sistema de cálculo de orçamento. O objetivo é definir e analisar os elementos que orientam o desenvolvimento da solução, especificando requisitos, regras e restrições a partir da perspectiva do usuário.

**Legenda de prioridade:**

- **Alta:** essencial para a primeira versão do sistema.
- **Média:** importante, mas pode ser implementado após o funcionamento principal.
- **Baixa:** desejável para melhorias futuras.

---

# Requisitos Funcionais (RF) — O que o sistema deve fazer

- **RF01:** Adicionar nome do serviço e nome do cliente. **| Prioridade: Alta**
- **RF02:** Verificar se o trabalho já foi feito anteriormente. **| Prioridade: Média**
- **RF03:** Mostrar trabalhos feitos com data, cliente, quantidade e preço. **| Prioridade: Média**
- **RF04:** Adicionar número da OS. **| Prioridade: Alta**
- **RF05:** Adicionar tamanho do produto. **| Prioridade: Alta**
- **RF06:** Adicionar quantidade solicitada. **| Prioridade: Alta**
- **RF07:** Selecionar material e chapa. **| Prioridade: Alta**
- **RF08:** Selecionar setor de produção, como impressão e corte. **| Prioridade: Alta**
- **RF09:** Selecionar máquina ou processo, como Mimaki JFX, Esko ou Map Cut. **| Prioridade: Alta**
- **RF10:** Fazer cálculo de montagem. **| Prioridade: Alta**
- **RF11:** Calcular aproveitamento da chapa e quantidade de chapas. **| Prioridade: Alta**
- **RF12:** Fazer cálculo de Matéria-Prima (aproveitamento da chapa, quantidade de chapas, perda de produção, custo do substrato, tinta, embalagem e demais materiais). **| Prioridade: Alta**
- **RF13:** Fazer cálculo de Produção (tempo e custo da Mimaki JFX, tempo e custo da Esko ou Map Cut, setup, impressão, corte e acabamento). **| Prioridade: Alta**
- **RF14:** Fazer cálculo de Serviços Terceiros (frete, faca especial, fotolito/CTP e outros serviços externos). **| Prioridade: Média**
- **RF15:** Fazer cálculo de Preço de Venda (preço de custo, custo unitário, margem de lucro, comissões, impostos, taxa de juros, índice de venda, preço total e preço unitário de venda). **| Prioridade: Alta**
- **RF16:** Salvar e consultar orçamentos feitos. **| Prioridade: Alta**
- **RF17:** Permitir duplicar orçamento anterior. **| Prioridade: Média**
- **RF18:** Gerar PDF do orçamento. **| Prioridade: Alta**
- **RF19:** Gerar versão interna com custos e versão comercial para o cliente. **| Prioridade: Alta**

---

# Requisitos Não Funcionais (RNF) — Como o sistema deve funcionar

- **RNF01:** O sistema deve ser simples e intuitivo para o orçamentista. **| Prioridade: Alta**
- **RNF02:** O sistema deve calcular os valores rapidamente. **| Prioridade: Alta**
- **RNF03:** O sistema deve garantir precisão nos cálculos de orçamento. **| Prioridade: Alta**
- **RNF04:** O sistema deve validar campos obrigatórios antes de calcular. **| Prioridade: Alta**
- **RNF05:** O sistema deve proteger custos, margens e comissões internas. **| Prioridade: Alta**
- **RNF06:** O sistema deve salvar o histórico dos orçamentos com segurança. **| Prioridade: Alta**
- **RNF07:** O sistema deve manter os valores originais de cada orçamento salvo. **| Prioridade: Alta**
- **RNF08:** O sistema deve permitir atualização de materiais, máquinas e percentuais. **| Prioridade: Alta**
- **RNF09:** O sistema deve gerar PDFs profissionais e legíveis. **| Prioridade: Média**
- **RNF10:** O sistema deve funcionar em computadores Windows. **| Prioridade: Alta**
- **RNF11:** O sistema deve permitir backup dos dados. **| Prioridade: Alta**
- **RNF12:** O sistema deve estar preparado para futuras integrações e novos serviços gráficos. **| Prioridade: Baixa**

---

# Regras de Negócio (RN) — Como o processo deve funcionar

- **RN01:** O orçamento deve ter nome do serviço, cliente, quantidade e material selecionado. **| Prioridade: Alta**
- **RN02:** O sistema deve verificar se já existe orçamento parecido feito anteriormente. **| Prioridade: Média**
- **RN03:** Todas as medidas devem ser convertidas para a mesma unidade antes do cálculo. **| Prioridade: Alta**
- **RN04:** O cálculo de montagem deve considerar tamanho da peça, tamanho da chapa, sangria e abertura. **| Prioridade: Alta**
- **RN05:** O sistema deve calcular o aproveitamento da chapa na posição normal e girada. **| Prioridade: Alta**
- **RN06:** O sistema deve escolher automaticamente a montagem com maior aproveitamento. **| Prioridade: Alta**
- **RN07:** A quantidade de chapas deve sempre ser arredondada para cima. **| Prioridade: Alta**
- **RN08:** As perdas de produção devem ser adicionadas separadamente das chapas calculadas. **| Prioridade: Alta**
- **RN09:** O custo da matéria-prima deve considerar chapas, perdas, substrato, tinta, embalagem e demais materiais. **| Prioridade: Alta**
- **RN10:** O custo de produção deve considerar setup, impressão, corte, acabamento e mão de obra. **| Prioridade: Alta**
- **RN11:** O custo de terceiros deve considerar frete, faca especial, fotolito/CTP e serviços externos. **| Prioridade: Média**
- **RN12:** O preço de custo deve ser calculado pela soma de Matéria-Prima + Produção + Terceiros. **| Prioridade: Alta**
- **RN13:** O preço de venda deve considerar margem, comissões, impostos e juros. **| Prioridade: Alta**
- **RN14:** O sistema não deve permitir preço de venda abaixo do custo. **| Prioridade: Alta**
- **RN15:** A soma de margem, comissões, impostos e juros não pode ser igual ou superior a 100%. **| Prioridade: Alta**
- **RN16:** O orçamento salvo deve manter os custos usados na data em que foi criado. **| Prioridade: Alta**
- **RN17:** A versão enviada ao cliente não deve mostrar custo, margem, comissão ou dados internos. **| Prioridade: Alta**
- **RN18:** Alterações em materiais, custos e percentuais devem afetar apenas novos orçamentos, não os antigos já salvos. **| Prioridade: Alta**

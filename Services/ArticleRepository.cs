using TB.Models;
using System.Collections.Generic;
using System.Linq;

namespace TB.Services
{
    public static class ArticleRepository
    {
        private static readonly List<Article> _artigos = new()
        {
            // Artigo Destaque
            new Article
            {
                Id = 0,
                Categoria = "Destaque",
                Titulo = "O que a Novela \"Terra e Paixão\" Ensina Sobre Testamentos",
                Data = "22 out, 2025",
                TempoLeitura = "6 min",
                Imagem = "https://images.unsplash.com/photo-1450101499163-c8848c66ca85?w=800&q=80",
                Resumo = "A disputa pela herança entre os personagens da novela das 9 não é só ficção! Entenda como fazer um testamento válido e evitar brigas familiares após sua partida.",
                Slug = "testamento-novela",
                Conteudo = @"
                    <h2>Ficção que imita a realidade</h2>
                    <p>A novela Terra e Paixão trouxe à tona um tema que muitas famílias brasileiras enfrentam: a disputa por herança. O que vemos na TV acontece todos os dias nos tribunais do país.</p>
                    
                    <h3>Como fazer um testamento válido</h3>
                    <p>No Brasil, existem três tipos principais de testamento:</p>
                    <ul>
                        <li><strong>Testamento público:</strong> Feito em cartório com a presença de testemunhas</li>
                        <li><strong>Testamento cerrado:</strong> Escrito pelo testador e entregue lacrado ao tabelião</li>
                        <li><strong>Testamento particular:</strong> Escrito e assinado pelo testador na presença de três testemunhas</li>
                    </ul>
                    
                    <h3>Quem pode ser herdeiro?</h3>
                    <p>No Brasil, 50% dos bens são da legítima (reservados aos herdeiros necessários: filhos, cônjuge e pais). Os outros 50% podem ser deixados para quem você quiser.</p>
                    
                    <h3>Evite conflitos familiares</h3>
                    <p>Conversar com a família sobre o testamento ainda em vida pode evitar surpresas e brigas após sua partida. A transparência é fundamental.</p>
                    
                    <p><strong>Dica importante:</strong> Procure sempre um advogado especializado para elaborar seu testamento e garantir que ele seja válido juridicamente.</p>
                "
            },

            // Artigo 1
            new Article
            {
                Id = 1,
                Categoria = "Atualidades",
                Titulo = "CPI da Manipulação: O Que Você Precisa Saber Sobre Crimes Digitais",
                Data = "20 out, 2025",
                TempoLeitura = "5 min",
                Imagem = "https://images.unsplash.com/photo-1563986768609-322da13575f3?w=800&q=80",
                Resumo = "A CPI trouxe à tona crimes que muita gente comete sem saber. Descubra se você já foi vítima de manipulação digital e como se proteger legalmente.",
                Slug = "cpi-manipulacao",
                Conteudo = @"
                    <h2>O que é a CPI da Manipulação?</h2>
                    <p>A Comissão Parlamentar de Inquérito tem investigado diversos casos de crimes digitais que afetam milhares de brasileiros. Desde fake news até manipulação de dados pessoais, os crimes digitais se tornaram uma das principais preocupações jurídicas do país.</p>
                    
                    <h3>Principais pontos abordados</h3>
                    <ul>
                        <li><strong>Fake news e desinformação:</strong> A disseminação de informações falsas pode configurar crime contra a honra</li>
                        <li><strong>Manipulação de dados pessoais:</strong> Uso indevido de informações protegidas pela LGPD</li>
                        <li><strong>Crimes contra a honra na internet:</strong> Difamação, calúnia e injúria em redes sociais</li>
                        <li><strong>Manipulação de processos eleitorais:</strong> Uso de bots e perfis falsos</li>
                    </ul>
                    
                    <h3>Como se proteger?</h3>
                    <p>É fundamental que todos entendam seus direitos digitais. Algumas medidas importantes:</p>
                    <ul>
                        <li>Guarde provas (prints com data e hora, URLs completas)</li>
                        <li>Registre boletim de ocorrência imediatamente</li>
                        <li>Não exclua as mensagens ou posts ofensivos</li>
                        <li>Procure orientação jurídica especializada</li>
                    </ul>
                    
                    <p>Se você foi vítima de crimes digitais, não hesite em procurar ajuda profissional. O Direito Digital é uma área cada vez mais relevante e você tem amparo legal.</p>
                "
            },

            // Artigo 2
            new Article
            {
                Id = 2,
                Categoria = "Cultura Pop",
                Titulo = "Divórcio na Era do Instagram: Cuidado com o Que Você Posta!",
                Data = "18 out, 2025",
                TempoLeitura = "4 min",
                Imagem = "https://images.unsplash.com/photo-1611162617474-5b21e879e113?w=800&q=80",
                Resumo = "Aquela foto no stories pode ser usada contra você no processo de divórcio. Saiba o que evitar nas redes sociais durante a separação.",
                Slug = "divorcio-instagram",
                Conteudo = @"
                    <h2>Redes sociais como prova judicial</h2>
                    <p>Muita gente não sabe, mas posts em redes sociais podem (e são) usados como prova em processos de divórcio. Aquela foto ostentando na balada enquanto você alega não ter dinheiro pra pensão? Pode virar prova contra você.</p>
                    
                    <h3>O que evitar postar durante o divórcio</h3>
                    <ul>
                        <li>Fotos em festas e viagens caras (se você alega não ter dinheiro)</li>
                        <li>Comentários negativos sobre o ex-cônjuge</li>
                        <li>Fotos com novos parceiros antes da separação oficial</li>
                        <li>Informações sobre bens e patrimônio</li>
                        <li>Indiretas ou provocações ao ex</li>
                    </ul>
                    
                    <h3>Como as redes são usadas no processo</h3>
                    <p>Advogados usam prints de redes sociais para:</p>
                    <ul>
                        <li>Comprovar capacidade financeira real</li>
                        <li>Demonstrar conduta inadequada para guarda de filhos</li>
                        <li>Provar infidelidade ou traição</li>
                        <li>Mostrar alienação parental</li>
                    </ul>
                    
                    <p><strong>Dica de ouro:</strong> Durante o processo de divórcio, pense duas vezes antes de postar qualquer coisa. O melhor é manter perfil baixo nas redes sociais.</p>
                "
            },

            // Artigo 3
            new Article
            {
                Id = 3,
                Categoria = "Dicas Práticas",
                Titulo = "Acordo Pré-Nupcial: Por Que Conversar Sobre Dinheiro ANTES de Casar",
                Data = "15 out, 2025",
                TempoLeitura = "7 min",
                Imagem = "https://images.unsplash.com/photo-1519225421980-715cb0215aed?w=800&q=80",
                Resumo = "Falar de grana não é falta de romantismo! Veja como um simples acordo pode salvar seu patrimônio e seu casamento no futuro.",
                Slug = "acordo-pre-nupcial",
                Conteudo = @"
                    <h2>Por que fazer um acordo pré-nupcial?</h2>
                    <p>Muitos casais evitam esse assunto por acharem que demonstra desconfiança ou falta de romantismo. Mas a verdade é justamente o contrário: conversar sobre finanças antes do casamento demonstra maturidade e responsabilidade.</p>
                    
                    <h3>O que é o pacto antenupcial?</h3>
                    <p>É um documento feito antes do casamento onde o casal define como será a divisão de bens. Ele precisa ser registrado em cartório e pode escolher entre diferentes regimes:</p>
                    <ul>
                        <li><strong>Comunhão parcial de bens:</strong> Regime padrão no Brasil (divide só o que foi adquirido após o casamento)</li>
                        <li><strong>Comunhão universal:</strong> Todos os bens são divididos, inclusive os anteriores ao casamento</li>
                        <li><strong>Separação total:</strong> Cada um mantém seu patrimônio separado</li>
                        <li><strong>Participação final nos aquestos:</strong> União de características dos outros regimes</li>
                    </ul>
                    
                    <h3>Vantagens do acordo</h3>
                    <ul>
                        <li>Proteção patrimonial em caso de divórcio</li>
                        <li>Clareza nas finanças do casal</li>
                        <li>Evita conflitos futuros</li>
                        <li>Protege herança familiar</li>
                        <li>Facilita processos de inventário</li>
                        <li>Define responsabilidades financeiras</li>
                    </ul>
                    
                    <h3>Quando fazer?</h3>
                    <p>O ideal é fazer o pacto antenupcial ANTES da data do casamento. Depois de casado, só é possível alterar o regime de bens através de um processo judicial específico, que exige autorização do juiz.</p>
                    
                    <h3>Quanto custa?</h3>
                    <p>O custo varia de acordo com o estado, mas geralmente fica entre R$ 1.500 e R$ 3.000, incluindo a elaboração do documento e o registro em cartório.</p>
                    
                    <p><strong>Dica da advogada:</strong> Não deixe para a última hora! O processo de elaboração e registro do pacto pode levar alguns dias. Comece a conversar sobre isso pelo menos 2 meses antes do casamento.</p>
                "
            },

            // Artigo 4
            new Article
            {
                Id = 4,
                Categoria = "Curiosidades",
                Titulo = "5 Coisas Que Você Não Sabia Sobre Guarda Compartilhada",
                Data = "12 out, 2025",
                TempoLeitura = "6 min",
                Imagem = "https://images.unsplash.com/photo-1476234251651-f353703a034d?w=800&q=80",
                Resumo = "Guarda compartilhada não é só 'fim de semana sim, fim de semana não'. Descubra o que realmente significa e como funciona na prática.",
                Slug = "guarda-compartilhada",
                Conteudo = @"
                    <h2>Mitos e verdades sobre guarda compartilhada</h2>
                    <p>A guarda compartilhada é a regra no Brasil desde 2014, mas muita gente ainda tem dúvidas sobre como ela funciona na prática.</p>
                    
                    <h3>1. Guarda compartilhada não é dividir o tempo meio a meio</h3>
                    <p>Muita gente acha que guarda compartilhada significa que a criança fica metade do tempo com cada genitor. Na verdade, ela se refere à RESPONSABILIDADE compartilhada sobre decisões importantes da vida dos filhos (escola, saúde, educação), não necessariamente sobre o tempo de convivência.</p>
                    
                    <h3>2. A criança pode ter uma residência principal</h3>
                    <p>Na guarda compartilhada, geralmente a criança tem uma casa principal (onde fica durante a semana) e visita o outro genitor regularmente. O importante é que ambos participem das decisões.</p>
                    
                    <h3>3. Pensão alimentícia continua existindo</h3>
                    <p>Mesmo com guarda compartilhada, quem ganha mais ou tem menos tempo com a criança normalmente paga pensão alimentícia. A responsabilidade financeira não é automaticamente dividida ao meio.</p>
                    
                    <h3>4. É preciso haver acordo sobre tudo</h3>
                    <p>Escola, médico, viagens, atividades extracurriculares - tudo precisa ser decidido em conjunto. Se não houver acordo, o juiz decide.</p>
                    
                    <h3>5. Pode ser revista a qualquer momento</h3>
                    <p>Se a guarda compartilhada não estiver funcionando, qualquer um dos pais pode pedir revisão judicial. O que importa é sempre o melhor interesse da criança.</p>
                    
                    <p><strong>Atenção:</strong> A guarda compartilhada só não é aplicada quando um dos genitores declara não querer a guarda ou quando há risco para a criança (violência, abuso, negligência).</p>
                "
            },

            // Artigo 5
            new Article
            {
                Id = 5,
                Categoria = "Atualidades",
                Titulo = "Minha Casa Minha Vida 2025: Novos Direitos e Como Não Perder Seu Imóvel",
                Data = "10 out, 2025",
                TempoLeitura = "8 min",
                Imagem = "https://images.unsplash.com/photo-1560518883-ce09059eeffa?w=800&q=80",
                Resumo = "Mudanças no programa podem afetar quem já tem financiamento. Entenda seus direitos e evite cair em golpes imobiliários.",
                Slug = "minha-casa-minha-vida",
                Conteudo = @"
                    <h2>Novidades do Minha Casa Minha Vida em 2025</h2>
                    <p>O programa habitacional passou por importantes mudanças neste ano. Se você já tem financiamento ou pretende entrar no programa, precisa ficar atento.</p>
                    
                    <h3>Principais mudanças</h3>
                    <ul>
                        <li>Ampliação da faixa de renda atendida</li>
                        <li>Novas regras para subsídio</li>
                        <li>Mudanças nas taxas de juros</li>
                        <li>Facilitação para famílias chefiadas por mulheres</li>
                    </ul>
                    
                    <h3>Seus direitos como beneficiário</h3>
                    <p>Quem já tem imóvel pelo programa precisa saber que:</p>
                    <ul>
                        <li>Não pode vender o imóvel antes de 10 anos (salvo casos específicos)</li>
                        <li>Pode alugar o imóvel em casos de necessidade comprovada</li>
                        <li>Tem direito a revisão de prestações em caso de desemprego</li>
                        <li>Pode solicitar portabilidade do financiamento</li>
                    </ul>
                    
                    <h3>Cuidado com golpes</h3>
                    <p>Aumentaram os casos de golpes relacionados ao programa:</p>
                    <ul>
                        <li><strong>Falsos corretores:</strong> Prometem vaga no programa mediante pagamento</li>
                        <li><strong>Documentos falsos:</strong> Vendem 'vagas' inexistentes</li>
                        <li><strong>Cobranças indevidas:</strong> Pedem dinheiro para 'agilizar' processo</li>
                    </ul>
                    
                    <h3>Como não perder seu imóvel</h3>
                    <p>Para evitar a perda do imóvel:</p>
                    <ul>
                        <li>Pague as prestações em dia (prioridade no orçamento!)</li>
                        <li>Em caso de dificuldade, procure a Caixa IMEDIATAMENTE</li>
                        <li>Não abandone o imóvel</li>
                        <li>Mantenha seus dados cadastrais atualizados</li>
                        <li>Guarde todos os comprovantes de pagamento</li>
                    </ul>
                    
                    <p><strong>Importante:</strong> A Caixa Econômica Federal é o único agente financeiro oficial do programa. Desconfie de intermediários que pedem dinheiro adiantado.</p>
                "
            },

            // Artigo 6
            new Article
            {
                Id = 6,
                Categoria = "Cultura Pop",
                Titulo = "BBB24: Contratos, Direitos de Imagem e o Que os Brothers Assinam",
                Data = "8 out, 2025",
                TempoLeitura = "5 min",
                Imagem = "https://images.unsplash.com/photo-1522869635100-9f4c5e86aa37?w=800&q=80",
                Resumo = "Você sabia que os participantes assinam contratos pesados? Descubra o que está escrito nas entrelinhas dos reality shows.",
                Slug = "contratos-bbb",
                Conteudo = @"
                    <h2>O que os brothers assinam antes de entrar</h2>
                    <p>Participar de um reality show não é simplesmente entrar numa casa e começar a ser filmado. Há um contrato extenso que poucos conhecem os detalhes.</p>
                    
                    <h3>Principais cláusulas do contrato do BBB</h3>
                    <ul>
                        <li><strong>Cessão de imagem:</strong> A Globo pode usar a imagem do participante por tempo indeterminado</li>
                        <li><strong>Confidencialidade:</strong> Proibição de revelar bastidores por até 2 anos</li>
                        <li><strong>Exclusividade:</strong> Participantes não podem fazer outros programas durante o contrato</li>
                        <li><strong>Direito de edição:</strong> A emissora pode editar e usar o conteúdo como quiser</li>
                        <li><strong>Penalidades:</strong> Multas altíssimas por quebra de contrato</li>
                    </ul>
                    
                    <h3>Direitos de imagem: o que pode e não pode</h3>
                    <p>Depois do programa:</p>
                    <ul>
                        <li>Participantes não podem usar trechos do programa sem autorização</li>
                        <li>A Globo pode lucrar eternamente com reprises e compilações</li>
                        <li>Lives comentando o programa podem render processos</li>
                        <li>Uso comercial da imagem depende de autorização</li>
                    </ul>
                    
                    <h3>Vale a pena?</h3>
                    <p>Apesar das restrições, para muitos vale a pena pela visibilidade:</p>
                    <ul>
                        <li>Ganho de milhões de seguidores</li>
                        <li>Oportunidades profissionais após o programa</li>
                        <li>Contratos publicitários milionários</li>
                        <li>Chance de ganhar o prêmio (R$ 1,5 milhão em 2024)</li>
                    </ul>
                    
                    <p><strong>Curiosidade jurídica:</strong> Alguns ex-BBBs já processaram a Globo por uso indevido de imagem, mas a maioria dos casos foi vencida pela emissora devido às cláusulas contratuais.</p>
                "
            },

            // Artigo 7
            new Article
            {
                Id = 7,
                Categoria = "Dicas Práticas",
                Titulo = "Bloqueou o Ex nas Redes? Isso Pode Afetar Seu Processo!",
                Data = "5 out, 2025",
                TempoLeitura = "4 min",
                Imagem = "https://images.unsplash.com/photo-1516251193007-45ef944ab0c6?w=800&q=80",
                Resumo = "Parece besteira, mas ações digitais têm consequências jurídicas reais. Veja como agir nas redes durante disputas legais.",
                Slug = "bloqueio-redes-sociais",
                Conteudo = @"
                    <h2>Redes sociais e processos judiciais</h2>
                    <p>Bloquear alguém nas redes sociais parece inofensivo, mas pode ter consequências jurídicas inesperadas, principalmente em casos de guarda de filhos e pensão alimentícia.</p>
                    
                    <h3>Por que o bloqueio pode prejudicar você</h3>
                    <ul>
                        <li><strong>Alienação parental:</strong> Impedir acesso a fotos dos filhos pode ser interpretado como tentativa de afastar o genitor</li>
                        <li><strong>Ocultação de provas:</strong> Bloquear após discussões pode parecer que você está escondendo algo</li>
                        <li><strong>Dificuldade de comunicação:</strong> Pode ser usado como argumento de que você dificulta o diálogo</li>
                        <li><strong>Má-fé processual:</strong> Pode ser visto como obstrução ao direito de defesa</li>
                    </ul>
                    
                    <h3>O que fazer então?</h3>
                    <p>Em vez de bloquear:</p>
                    <ul>
                        <li>Configure suas postagens como privadas</li>
                        <li>Limite quem pode ver fotos dos seus filhos</li>
                        <li>Use a função 'restringir' em vez de bloquear</li>
                        <li>Mantenha um canal de comunicação aberto (mesmo que por e-mail)</li>
                        <li>Documente tudo através de prints</li>
                    </ul>
                    
                    <h3>Quando o bloqueio é justificável</h3>
                    <p>Há situações em que bloquear é recomendado:</p>
                    <ul>
                        <li>Ameaças diretas ou indiretas</li>
                        <li>Assédio moral ou perseguição</li>
                        <li>Compartilhamento de informações falsas sobre você</li>
                        <li>Quando há medida protetiva em vigor</li>
                    </ul>
                    
                    <p><strong>Dica importante:</strong> Se precisar bloquear, documente o motivo. Tire prints das mensagens ou comportamentos que justificaram a atitude. Isso pode ser importante caso precise se defender posteriormente.</p>
                "
            },

            // Artigo 8
            new Article
            {
                Id = 8,
                Categoria = "Curiosidades",
                Titulo = "Pensão Alimentícia: Mitos e Verdades Que Ninguém Te Conta",
                Data = "3 out, 2025",
                TempoLeitura = "7 min",
                Imagem = "https://www.contabeis.com.br/assets/img/news/pensao-alimenticia-posso-deduzir-escola-que-pago.png",
                Resumo = "É verdade que só o pai paga pensão? E se ele estiver desempregado? Quebramos os principais mitos sobre pensão alimentícia.",
                Slug = "justica-e-elegancia",
                Conteudo = @"
                    <h2>Desvendando os mitos sobre pensão alimentícia</h2>
                    <p>Existem muitas informações erradas circulando sobre pensão alimentícia. Vamos esclarecer os principais mitos e verdades.</p>
                    
                    <h3>MITO 1: Só o pai paga pensão</h3>
                    <p><strong>VERDADE:</strong> Quem tem melhores condições financeiras paga, independente do gênero. Mães também podem pagar pensão aos filhos.</p>
                    
                    <h3>MITO 2: Desempregado não paga pensão</h3>
                    <p><strong>VERDADE:</strong> A obrigação continua mesmo desempregado. O juiz pode reduzir o valor, mas raramente zera. Se não pagar, pode até ser preso.</p>
                    
                    <h3>MITO 3: Pensão acaba aos 18 anos</h3>
                    <p><strong>VERDADE:</strong> Se o filho estiver estudando, a pensão pode continuar até os 24 anos (ou até terminar a graduação). É necessário entrar com ação de exoneração para parar de pagar.</p>
                    
                    <h3>MITO 4: O valor é sempre 30% do salário</h3>
                    <p><strong>VERDADE:</strong> Não existe percentual fixo. O juiz analisa: necessidades do filho + possibilidades do pagador. Pode ser 20%, 30%, 40% ou até mais.</p>
                    
                    <h3>MITO 5: Quem tem guarda não paga nada</h3>
                    <p><strong>VERDADE:</strong> Quem tem a guarda já contribui com moradia, alimentação diária, tempo. Mas em casos raros, pode haver contribuição adicional dependendo da disparidade financeira.</p>
                    
                    <h3>MITO 6: Novo casamento aumenta a pensão</h3>
                    <p><strong>VERDADE:</strong> Se quem recebe a pensão casar de novo, isso NÃO afeta a pensão dos filhos (só afeta pensão entre ex-cônjuges). Se quem PAGA casar e ter novos filhos, pode pedir redução do valor.</p>
                    
                    <h3>MITO 7: Só cobre dívida de 3 meses</h3>
                    <p><strong>VERDADE:</strong> A prisão só pode ser decretada por dívidas dos últimos 3 meses. MAS você pode cobrar judicialmente até 2 anos de atraso (prescrição bienal).</p>
                    
                    <h3>VERDADES que ninguém fala</h3>
                    <ul>
                        <li>Pensão atrasada rende juros de 1% ao mês + correção monetária</li>
                        <li>Pode incluir plano de saúde, escola, material escolar (se especificado)</li>
                        <li>Avós podem ser obrigados a pagar se o pai não tiver condições</li>
                        <li>Mãe que não permite visitas pode perder a guarda</li>
                        <li>Acordo feito em cartório tem força de sentença judicial</li>
                    </ul>
                    
                    <p><strong>Atenção:</strong> Cada caso é único. Essas são diretrizes gerais, mas a decisão final sempre depende da análise do juiz sobre sua situação específica.</p>
                "
            },
        };
        //GetAll() - retorna todos os artigos
        public static List<Article> GetAll() => _artigos;
        //GetBySlug() - retorna um artigo específico pelo slug
        public static Article? GetBySlug(string slug)
            => _artigos.FirstOrDefault(a => a.Slug == slug);
        //GetByCategoria() - retorna artigos por categoria
        public static List<Article> GetByCategoria(string categoria)
            => _artigos.Where(a => a.Categoria.ToLower() == categoria.ToLower()).ToList();
    }
}
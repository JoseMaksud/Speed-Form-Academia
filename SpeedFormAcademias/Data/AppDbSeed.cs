using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SpeedFormAcademias.Models;

namespace SpeedFormAcademias.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Modalidade
        List<Modalidade> modalidades = new() {
            new Modalidade() {
                Id = 1,
                Nome = "Funcional",
                DescricaoPT1 = "Originado na década de 1990, o treino funcional surgiu como uma abordagem inovadora no MUNDO DO FITNESS, focando em MOVIMENTOS NATURAIS e integrados que replicam as atividades diárias. Inspirado por treinamentos usados por atletas e reabilitação física, o TREINO FUNCIONAL foi projetado para MELHORAR A FORÇA, a FLEXIBILIDADE e a ESTABILIDADE através de exercícios que envolvem múltiplos grupos musculares. Desde sua criação, tem se tornado uma escolha popular para aqueles que buscam um TREINO EFICIENTE e ADAPTÁVEL.",
                DescricaoPT2 = "Na SPEEDFORM, o treino funcional é realizado seguindo uma ESTRUTURA DINÂMICA e personalizada para maximizar os resultados. Nossas sessões incluem uma VARIEDADE DE EXECÍCIOS que imitam MOVIMENTOS COTIDIANOS, como AGACHAMENTOS, LEVANTAMENTOS e SALTOS, utilizando equipamentos como KETTLEBELLS, BARRAS e BOLAS MEDICINAIS. Cada treino é cuidadosamente planejado para trabalhar diferentes partes do corpo e MELHORAR A COORDENAÇÃO, o EQUILÍBRIO e a FORÇA FUNCIONAL. Com INSTRUTORES EXPERIENTES e TECNICAS ADAPTATIVAS, garantimos um ambiente seguro e motivador para todos os níveis de condicionamento físico.",
                DescricaoPT3 = "Os BENEFÍCIOS do TREINO FUNCIONAL são amplos e impactam positivamente diversos aspectos da SAÚDE e BEM-ESTAR. Ao melhorar a FORÇA FUNCIONAL, a RESISTÊNCIA e a MOBILIDADE, você não só otimiza seu desempenho em atividades diárias, mas também REDUZ RISCOS DE LESÕES e MELHORA A POSTURA. O treino funcional também é conhecido por aumentar a eficiência do METABOLISMO e auxiliar na PERDA DE PESO, proporcionando um treino completo que se adapta às suas necessidades e objetivos. Na SPEEDFORM, estamos comprometidos em ajudá-lo a alcançar uma VIDA MAIS ATIVA E SAUDÁVEL com o TREINO FUNCIONAL. Venha experimentar e descubra como essa abordagem inovadora pode transformar seu condicionamento físico e sua qualidade de vida!",
                Imagem = @"img/modalidades/1.jpg",
                Imagem2 = @"img/modalidades/2.jpg",
            },
            new Modalidade() {
                Id = 2,
                 Nome = "Spinning",
                DescricaoPT1 = "Originado na década de 1990, o SPINNING foi desenvolvido por Johnny Goldberg, um ciclista e treinador, que criou um TREINO DE ALTA INTENSIDADE projetado para replicar a experiência de andar de BICICLETA em diferentes terrenos e condições. Desde então, o SPINNING tem conquistado entusiastas do fitness ao redor do mundo, oferecendo uma forma eficiente e emocionante de MELHORAR O CONDICIONAMENTO CARDIOVASCULAR e a FORÇA MUSCULAR.",
                DescricaoPT2 = "Na SPEEDFORM, nossas aulas de SPINNING são conduzidas por instrutores especializados que garantem uma EXPERIÊNCIA SEGURA e PERSONALIDADE. Cada sessão se passa em BICICLETAS ERGONÔMICAS projetadas para simular diferentes tipos de pedaladas, como subidas e sprints, acompanhadas por músicas energizantes e um ambiente motivador. As aulas seguem um formato estruturado, começando com um AQUECIMENTO GRADUAL, seguido por INTERVALOS DE ALTA INTENSIDADE e uma FASE DE RECUPERAÇÃO. O ritmo e a resistência das bicicletas são ajustáveis, permitindo que cada participante personalize seu treino conforme suas necessidades e objetivos individuais.",
                DescricaoPT3 = " Os BENEFÍCIOS do SPINNING são numerosos e impactam positivamente a sua saúde geral. Esse exercício cardiovascular intenso MELHORA A RESISTÊNCIA e a CAPACIDADE PULMONAR, além de promover a QUEIMA EFICAZ DE CALORIAS e o FORTALECIMENTO DOS MUSCULOS DA PERNA E DOS GLÚTEOS. Além disso, o SPINNING ajuda a reduzir o estresse e aumenta o BEM-ESTAR MENTAL ao proporcionar uma sensação de realização e energia após cada sessão. Na SPEEDFORM, você encontrará o ambiente perfeito para se desafiar e alcançar suas metas de fitness com a empolgação e a eficácia do SPINNING. Venha pedalar conosco e descubra como essa experiência vibrante pode transformar seu corpo e sua mente!",
                Imagem = @"img/modalidades/3.jpg",
                Imagem2 = @"img/modalidades/4.jpg",
            },
            new Modalidade() {
                Id = 3,
                Nome = "Musculação",
                DescricaoPT1 = "A MUSCULAÇÃO, uma prática voltada para o FORTALECIMENTO e CRESCIMENTO MUSCULAR, se desenvolveu como uma das atividades físicas mais populares nas academias modernas, como a SPEEDFORM. Utilizando aparelhos e pesos, a MUSCULAÇÃO surgiu como uma forma eficaz de aumentar a MASSA MUSCULAR e melhorar a SAÚDE GERAL. Com a prática constante, é possível observar significativas melhorias na DENSIDADE ÓSSEA e na FLEXIBILIDADE das articulações, além de oferecer suporte no CONTROLE DE PESOS e na SAÚDE CARDIOVASCULAR.",
                DescricaoPT2 = "Na MUSCULAÇÃO, os exercícios envolvem a CONTRAÇÃO DOS MUSCULOS contra uma resistência externa, que pode ser proporcionada por equipamentos de ginástica ou pesos livres. A principal meta é a HIPERTRODIA MUSCULAR, ou seja, o crescimento dos músculos, que contribui para um AUMENTO DE FORÇA e do CONDICIONAMENTO FÍSICO GERAL. Para alcançar esses objetivos, é fundamental seguir um programa de treinamento cuidadosamente elaborado e SUPERVISIONADOS POR PROFISSIONAIS QUALIFICADOS para evitar lesões e garantir a eficácia dos treinos.",
                DescricaoPT3 = " Os BENEFÍCIOS DA MUSCULAÇÃO vão além do simples aumento da massa muscular. Ela auxilia na melhora da densidade óssea, o que REDUZ O RISCO DE FRATURAS e problemas como a osteoporose, e pode também ajudar na PERDA DE PESO e no CONTROLE DE AÇÚCAR NO SANGUE. Além disso, a prática regular de MUSCULAÇÃO está associada à redução de fadiga, ansiedade e depressão, e MELHORA A QUALIDADE DO SONO e do EQUILÍBRIO. Apesar desses muitos benefícios, é essencial que a prática seja bem orientada e respeite períodos de descanso para prevenir lesões e garantir a recuperação muscular adequada.",
                Imagem = @"img/modalidades/7.jpg",
                Imagem2 = @"img/modalidades/8.jpg",
            },
            new Modalidade() {
                Id = 4,
                 Nome = "Muay Thai",
                DescricaoPT1 = "O MUAY THAY, uma arte marcial milenar originária da Tailândia, é amplamente praticado e admirado nas academias brasileiras, e a SPEEDFORM não é diferente. Este esporte começou há cerca de dois mil anos, quando agricultores tailandeses desenvolveram técnicas de combate utilizando socos, chutes, joelhadas e cotoveladas, EVITANDO FERIMENTOS GRAVES que poderiam ocorrer com armas. A tradição é simbolizada pelo uso da corda trançada chamada KRUANG, que representa a graduação do praticante. Com o tempo, o MUAY THAI evoluiu para o que conhecemos hoje, mantendo sua essência de combate com as 'oito armas': punhos, cotovelos, joelhos e canelas.",
                DescricaoPT2 = "As regras do MUAY THAI incluem o uso de todos os segmentos do corpo para atacar e se defender, o que exige uma técnica refinada e disciplina. A luta se diferencia de outras modalidades, como o KICKBOXING, pelo uso específico das cotoveladas e a prática do CLINCH, onde os lutadores se agarram e utilizam joelhos. Equipamentos de proteção, como luvas, caneleiras e protetores bucais, são essenciais para GARANTIR A SEGURANÇA dos praticantes durante os treinos e competições. Além disso, o MUAY THAI exige um treino rigoroso e técnico, que pode ser adaptado para diferentes níveis de habilidade e objetivos, desde o fitness até a competição.",
                DescricaoPT3 = "Os benefícios do MUAY THAI são vastos e vão além do condicionamento físico. Praticar esta arte marcial ajuda na perda de peso, queimando entre 600 A 900 CALORIAS por hora, e melhora o REFLEXO, a FLEXIBILIDADE e a AUTOESTIMA. Além disso, o treino contribui para o aumento da massa muscular, alívio do estresse e desenvolvimento do autocontrole e da postura. A filosofia da SPEEDFORM valoriza tanto o APRIMORAMENTO TÉCNICO quanto a promoção da QUALIDADE DE VIDA, fazendo do MUAY THAI uma excelente escolha para quem busca uma atividade física completa e enriquecedora.",
                Imagem = @"img/modalidades/5.jpg",
                Imagem2 = @"img/modalidades/6.jpg",
            },
            new Modalidade() {
                Id = 5,
                Nome = "Jiu Jitsu",
                DescricaoPT1 = "Com origens no Japão feudal, o JIU-JITSU foi desenvolvido pelos samurais como uma técnica de combate eficiente para desarmar e controlar adversários sem armas. No início do século 20, o JIU-JITSU foi adaptado e refinado no Brasil pelos irmãos Gracie, transformando-se no que conhecemos hoje como JIU-JITSU BRASILEIRO. Essa evolução trouxe a arte marcial para os holofotes internacionais, popularizando-a como um dos pilares das ARTES MARCIAIS MISTAS (MMA).",
                DescricaoPT2 = "Na SPEEDFORM, oferecemos aulas de JIU-JITSU conduzidas por INSTRUTORES ALTAMENTE QUALIFICADOS que seguem as regras tradicionais e modernas do esporte. O JIU-JITSU é baseado em TÉCNICAS DE ALAVANCAS, IMOBILIZAÇÕES e FINALIZAÇÕES, com o objetivo de controlar ou submeter o adversário de forma eficiente. Durante as aulas, você aprenderá a EXECUTAR e DEFENDER TÉCNICAS em um AMBIENTE SEGURO e ESTRUTURADO. As competições seguem um conjunto de regras que priorizam a SEGURANÇA DOS PARTIPANTES, com pontos atribuídos por técnicas eficazes e penalidades para ações ilegais.",
                DescricaoPT3 = "Os BENEFÍCIOS do JIU-JITSU vão além do DESENVOLVIMENTO FÍSICO, proporcionando ganhos significativos na SAÚDE MENTAL E EMOCIONAL. Praticar JIU-JITSU melhora a FORÇA, a FLEXIBILIDADE e o CONDICIONAMENTO CARDIOVASCULAR, além de promover habilidades de AUTODEFESA e AUTOCONFIANÇA. O esporte também é excelente para ALIVIAR O ESTRESSE e MELHORAR O FOCO, ao mesmo tempo em que desenvolve a DISCIPLINA e o ESPÍRITO DE EQUIPE. Na SPEEDFORM, convidamos você a experimentar o JIU-JITSU e a descobrir como essa arte marcial pode transformar sua vida, oferecendo um treino completo e enriquecedor. Venha para a SPEEDFORM e mergulhe no universo fascinante do JIU-JITSU!",
                Imagem = @"img/modalidades/9.jpg",
                Imagem2 = @"img/modalidades/10.jpg",
            },
            new Modalidade() {
                Id = 6,
                Nome = "Aeroboxe",
                DescricaoPT1 = "Seja bem-vindo à revolução do fitness com o AEROBOXE da SPEEDFORM! Este esporte, uma fusão dinâmica de BOXE e AERÓBICA, tem suas raízes na década de 1980, quando instrutores visionários combinaram movimentos de BOXE com EXERCÍCIOS AERÓBICOS para criar um treino envolvente e eficaz. O objetivo era proporcionar um treino cardiovascular intenso enquanto aprimorava a técnica de boxe. Desde então, o AEROBOXE tem conquistado o mundo, transformando-se em uma modalidade popular que oferece uma maneira empolgante e estimulante de se manter em forma.",
                DescricaoPT2 = "Na SPEEDFORM, o AEROBOXE é praticado seguindo regras bem definidas que garantem a SEGURANÇA e a eficácia do treino. As aulas são conduzidas por INSTRUTORES QUALIFICADOS e seguem uma estrutura específica: começamos com um AQUECIMENTO AERÓBICO para preparar o corpo, seguido de uma série de combinações de SOCOS E CHUTES COORDENADOS com MOVIMENTOS RÍTMICOS. Cada sessão termina com uma etapa de resfriamento e alongamento para ajudar na recuperação. Ao contrário do BOXE tradicional, o AEROBOXE não envolve contato físico entre os participantes, o que proporciona um AMBIENTE SEGURO E AMIGÁVEL para todos os níveis de habilidade.",
                DescricaoPT3 = " Os BENEFÍCIOS do AEROBOXE são notáveis e fazem dele uma escolha imbatível para quem busca um treino completo. Além de MELHORAR A RESISTÊNCIA CARDIOVASCULAR e a FORÇA MUSCULAR, o AEROBOXE também é excelente para a QUEIMA DE CALORIAS, contribuindo para a PERDA DE PESO e o AUMENTO DA DEFINIÇÃO CORPORAL. A natureza ritmada e intensa das aulas promove um elevado nível de endorfina, o que ajuda a REDUZIR O ESTRESSE e MELHORAR O HUMOR. Na SPEEDFORM, garantimos que você aproveite todos esses benefícios enquanto se diverte e se desafia. Junte-se a nós e experimente o AEROBOXE, onde a DIVERSÃO e a SAÚDE andam de mãos dadas!",
                Imagem = @"img/modalidades/11.jpg",
                Imagem2 = @"img/modalidades/12.jpg",
            },
            new Modalidade() {
                Id = 7,
                Nome = "Zumba",
                DescricaoPT1 = "Conheça a ZUMBA a SENSAÇÃO GLOBAL que está conquistando corações e corpos ao redor do mundo, e que agora está ao seu alcance nas academias SPEEDFORM! Criada na Colômbia na década de 1990 pelo dançarino e coreógrafo Alberto 'Beto' Pérez, a ZUMBA surgiu quando Beto decidiu usar músicas latinas e caribenhas em suas aulas de aeróbica, substituindo a trilha sonora tradicional. A combinação irresistível de RITMOS CONTAGIANTES e PASSOS SIMPLES resultou em uma PRÁTICA INOVADORA que rapidamente se espalhou, tornando-se um FENÔMENO MUNDIAL.",
                DescricaoPT2 = "Na SPEEDFORM, a ZUMBA é conduzida por instrutores altamente qualificados que garantem que você siga a diversão e as regras de forma eficaz. Cada aula é um EVENTO SOCIAL e FITNESS ao mesmo tempo, começando com um AQUECIMENTO DINÂMINCO seguido por SEQUÊNCIAS COREOGRÁFICAS que variam em intensidade, sempre mantendo a SEGURANÇA e o CONFORTO dos participantes. As aulas são projetadas para todos os níveis de habilidade, com movimentos fáceis de aprender e adaptar. O espírito inclusivo da ZUMBA é um dos maiores atrativos, promovendo um ambiente onde todos se sentem bem-vindos e motivados a se mover ao ritmo da música.",
                DescricaoPT3 = "A ZUMBA oferece uma série de BENEFÍCIOS para a saúde que você pode começar a desfrutar imediatamente. Participar regularmente das aulas ajuda a MELHORAR A CONDIÇÃO CARDIOVASCULAR, aumentar a FLEXIBILIDADE e TONIFICAR O CORPO, tudo isso enquanto QUEIMA CALORIAS de forma eficaz. Além disso, a INTERAÇÃO SOCIAL e a ENERGIA POSITIVA das aulas contribuem para uma melhora significativa no HUMOR e na AUTOESTIMA. Não perca a chance de experimentar tudo o que a ZUMBA tem a oferecer na SPEEDFORM e dar um impulso saudável e vibrante à sua vida!",
                Imagem = @"img/modalidades/13.jpg",
                Imagem2 = @"img/modalidades/14.jpg",
            },
            new Modalidade() {
                Id = 8,
                Nome = "Ritmo",
                DescricaoPT1 = "O RITMO, que se originou na rica tradição das DANÇAS e EXERCÍCIOS RÍTIMOS, é uma abordagem inovadora que combina MOVIMENTOS COREOGRAFADOS com MÚSICAS ANIMADAS para criar uma experiência de treino DINÂMICA e ENVOLVENTE. Inspirado pelos métodos de treinamento que utilizam a BATIDA DA MÚSICA para guiar os exercícios, o RITMO integra elementos de DANÇA, AERÓBICA e TREINO FUNCIONAL, garantindo uma fusão perfeita de diversão e eficácia desde suas primeiras aulas.",
                DescricaoPT2 = "Na SPEEDFORM, as aulas de RITMO são projetadas para serem ACESSÍVEIS e PRAZEROSAS para todos os níveis de habilidade. As regras são simples: SIGA O RITMO DA MÚSICA, acompanhe a COREOGRAFIA ADAPTÁVEL e mantenha-se atento às orientações dos nossos instrutores especializados. Cada sessão começa com um AQUECIMENTO ENERGIZANTE e avança para SEQUÊNCIAS COREOGRAFADAS que desafiam sua COORDENAÇÃO e RESISTÊNCIA. O objetivo é maximizar o impacto do treino enquanto você se diverte, e nossos profissionais garantem que cada movimento seja SEGURO e ADEQUADO às suas capacidades individuais.",
                DescricaoPT3 = " O RITMO oferece BENEFÍCIOS notáveis para sua SAÚDE e BEM-ESTAR. Ao participar das aulas regularmente, você experimentará um AUMENTO SIGNIFCATIVA NA SUA CAPACIDADE CARDIOVASCULAR, FORÇA MUSCULAR e FLEXIBILIDADE. A combinação de EXERCÍCIOS RÍTMICOS também promove a QUEIMA EFICAZ DE CALORIAS, ajudando a alcançar e manter um PESO SAUDÁVEL. Mais importante ainda, o RITMO melhora o HUMOR e REDUZ O ESTRESSE, proporcionando uma sensação geral de felicidade e realização. Junte-se a nós na SPEEDFORM e sinta a diferença que o RITMO pode fazer na sua vida!",
                Imagem = @"img/modalidades/15.jpg",
                Imagem2 = @"img/modalidades/16.jpg",
            }
        };

        builder.Entity<Modalidade>().HasData(modalidades);
        #endregion

        #region Populate Unidades
        List<Unidade> unidades = new() {
            new Unidade() {
                Id = 1,
                Nome = "Academia SPEED FORM - Barra Bonita",
                Localizacao = "Avenida Industrial - Av. Dr. José Erineu Ortigosa, 1178 - Distrito Industrial I, Barra Bonita - SP, 17340-000",
                LocalizacaoFoto = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3686.6949491297155!2d-48.57072462458257!3d-22.47809492269105!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c74fc00de511fb%3A0x1fac14b8cbbf87ef!2sAcademia%20SPEED%20FORM%20-%20Barra%20Bonita!5e0!3m2!1spt-BR!2sbr!4v1709730973592!5m2!1spt-BR!2sbr",
                Descricao = "Conheça as unidades MAIS PRÓXIMAS DE VOCÊ e faça parte da NOSSA HISTÓRIA!"
            },
            new Unidade() {
                Id = 2,
                Nome = "Academia SPEED FORM - Igaraçu do Tiete",
                Localizacao = "R. Sebastiana de Barros, 45 - Centro, Igaraçu do Tietê - SP, 17350-000",
                LocalizacaoFoto = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3685.726107662067!2d-48.562940718604!3d-22.514457171175422!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c745c39b48f297%3A0x1cbdc83432385263!2sAcademia%20SPEED%20FORM%20-%20Igara%C3%A7u%20do%20Tiete!5e0!3m2!1spt-BR!2sbr!4v1709731392106!5m2!1spt-BR!2sbr",
                Descricao = "Conheça as unidades MAIS PRÓXIMAS DE VOCÊ e faça parte da NOSSA HISTÓRIA!"
            },
        };
        builder.Entity<Unidade>().HasData(unidades);
        #endregion


        List<UnidadeFoto> unidadeFotos = new();
        for (int i = 1; i <= 2; i++)
            unidadeFotos.Add(new UnidadeFoto()
            {
                Id = i,
                UnidadeId = i,
                ArquivoFoto = $"/img/unidades/{i}/1.jpg",
                Destaque = true
            });
        unidadeFotos.Add(new UnidadeFoto()
        {
            Id = 3,
            UnidadeId = 1,
            ArquivoFoto = @"/img/unidades/1/2.jpg",
            Destaque = false
        });
        unidadeFotos.Add(new UnidadeFoto()
        {
            Id = 4,
            UnidadeId = 1,
            ArquivoFoto = $"/img/unidades/1/3.jpg",
            Destaque = false
        });
        unidadeFotos.Add(new UnidadeFoto()
        {
            Id = 5,
            UnidadeId = 1,
            ArquivoFoto = $"/img/unidades/1/4.jpg",
            Destaque = false
        });
        unidadeFotos.Add(new UnidadeFoto()
        {
            Id = 6,
            UnidadeId = 2,
            ArquivoFoto = @"/img/unidades/2/2.jpg",
            Destaque = false
        });
        unidadeFotos.Add(new UnidadeFoto()
        {
            Id = 7,
            UnidadeId = 2,
            ArquivoFoto = $"/img/unidades/2/3.jpg",
            Destaque = false
        });
        unidadeFotos.Add(new UnidadeFoto()
        {
            Id = 8,
            UnidadeId = 2,
            ArquivoFoto = $"/img/unidades/2/4.jpg",
            Destaque = false
        });
        builder.Entity<UnidadeFoto>().HasData(unidadeFotos);


        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "admin@speedform.com",
                NormalizedEmail = "ADMIN@SPEEDFORM.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            },
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "SpeedForm",
                Foto = "/img/usuarios/avatar.png"
            },
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}
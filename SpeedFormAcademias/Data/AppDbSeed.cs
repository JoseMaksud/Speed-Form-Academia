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
                Nome = "Musculação",
                Descricao = "A Speed Form oferece treinamento de musculação com aparelhos e pesos livres. Isso permite que os alunos trabalhem em sua força, resistência e condicionamento físico.",
                Imagem = @"images/modalidades/1.jpg",
            },
            new Modalidade() {
                Id = 2,
                Nome = "Treinamento Funcional",
                Descricao = "Além da musculação, a academia também oferece aulas funcionais. Essas aulas geralmente envolvem exercícios de corpo inteiro, focando na melhoria da mobilidade, equilíbrio e resistência.",
                Imagem = @"images/modalidades/2.jpg",
            },
            new Modalidade() {
                Id = 3,
                Nome = "Ritmos",
                Descricao = "Para quem gosta de dançar, a Speed Form oferece aulas de dança e ritmos. Isso é uma ótima maneira de se exercitar enquanto se diverte.",
                Imagem = @"images/modalidades/3.jpg",
            },
            new Modalidade() {
                Id = 4,
                Nome = "Jiu-Jitsu",
                Descricao = "O Jiu Jitsu é uma arte marcial japonesa que se concentra em técnicas de luta no solo. Ele enfatiza o uso de alavancas, estrangulamentos e imobilizações para controlar o oponente. Os praticantes de Jiu Jitsu aprendem a usar a força do oponente contra ele mesmo, tornando-o uma opção eficaz para autodefesa e competições esportivas.",
                Imagem = @"images/modalidades/4.jpg",
            },
            new Modalidade() {
                Id = 5,
                Nome = "Muay Thai",
                Descricao = "O Muay Thai é uma luta marcial tailandesa, conhecida como a “luta das 8 armas”. Essas armas são as partes do corpo utilizadas nos golpes: dois cotovelos, dois punhos, dois joelhos e a combinação das duas canelas e dos dois pés.",
                Imagem = @"images/modalidades/5.jpg",
            }
        };

        builder.Entity<Modalidade>().HasData(modalidades);
        #endregion

        #region Populate Unidades
        List<Unidade> unidades = new() {
            new Unidade() {
                Id = 1,
                Nome = "Academia SPEED FORM - Barra Bonita",
                Localizacao = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3686.6949491297155!2d-48.57072462458257!3d-22.47809492269105!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c74fc00de511fb%3A0x1fac14b8cbbf87ef!2sAcademia%20SPEED%20FORM%20-%20Barra%20Bonita!5e0!3m2!1spt-BR!2sbr!4v1709730973592!5m2!1spt-BR!2sbr",
            },
            new Unidade() {
                Id = 2,
                Nome = "Academia SPEED FORM - Igaraçu do Tiete",
                Localizacao = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3685.726107662067!2d-48.562940718604!3d-22.514457171175422!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c745c39b48f297%3A0x1cbdc83432385263!2sAcademia%20SPEED%20FORM%20-%20Igara%C3%A7u%20do%20Tiete!5e0!3m2!1spt-BR!2sbr!4v1709731392106!5m2!1spt-BR!2sbr",
            },
        };
        builder.Entity<Unidade>().HasData(unidades);
        #endregion


        List<UnidadeFoto> unidadeFotos = new();
        for (int i = 1; i <= 12; i++)
            unidadeFotos.Add(new UnidadeFoto()
            {
                Id = i,
                UnidadeId = i,
                ArquivoFoto = $"/images/unidades/{i}/1.jpg",
                Destaque = true
            });
        unidadeFotos.Add(new UnidadeFoto()
        {
            Id = 3,
            UnidadeId = 1,
            ArquivoFoto = @"/images/unidades/5/2.jpg",
            Destaque = false
        });
        unidadeFotos.Add(new UnidadeFoto()
        {
            Id = 4,
            UnidadeId = 1,
            ArquivoFoto = $"/images/unidades/5/3.jpg",
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
                Email = "admin@SPEEDFORM.com",
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
using PruebaTime.Models;
using PruebaTime.ViewModel.MasterViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTime.Repository
{
    public class ChistesRepository
    {
        #region Attributes
        private List<ListChistesModel> list { get; set; }
        #endregion

        #region Properties
        public List<ListChistesModel> Listt
        {
            get { return this.list; }
            set { this.list = value; }
        }
        #endregion

        #region Constructor
        public ChistesRepository()
        {
            GetList();
        }
        #endregion

        #region Methods
        public void GetList()
        {
            Listt = new List<ListChistesModel>();

            //Chistes de animales.
            #region Animales
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Por qué los perros tienen pulgas? " +
                    "Porque las pulgas no pueden tener perros.",
                Category = "Animales"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Por qué no invitaron a los changos a la fiesta? " +
                "Porque era PA - CHANGA. ",
                Category = "Animales"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Qué le dijo una gallina deprimida a otra? " +
                "Necesito a - pollo. ",
                Category = "Animales"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Un gato en auto se estrella con el de un gallo, " +
                "y dice: -Miauto! Miauto! Responde el gallo: -¿Y quiquirí quilehaga? ",
                Category = "Animales"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Dos vacas conversando: -Oye que tragedia lo de las vacas locas " +
                "- A mi no me preocupa, yo soy un elefante rosado",
                Category = "Animales"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Una culebra le pregunta a otra: " +
                "¿Es cierto que somos venenosas ? " +
                "Sí, ¿por qué ? " +
                "Es que me mordí la lengua.",
                Category = "Animales"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Había una vez una mariposa tan enamorada " +
                "que sentía personas en el estómago... ",
                Category = "Animales"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Había un gato con 16 vidas lo aplastó una 4x4 y se murió. ",
                Category = "Animales"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Cuántos pasos da un perro en su vida? " +
                "Los mismos queda de bajada.",
                Category = "Animales"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Había una vez dos pulgas, se ganaron la lotería, " +
                "y se compraron un perro... ",
                Category = "Animales"
            });
            #endregion

            //Chistes de borrachos.
            #region Borrachos
            Listt.Add(new ListChistesModel
            {
                Chiste = "-¿Cuál es el país que se puede beber? -Cuba. " +
                "-¡No, Jamaica, pinche borracho! ",
                Category = "Borrachos"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "-¡Ah, cuánto caón vino! " +
                "Dos parroquianos se levantan al oírse llamar así. " +
                "- Y también cuánta caona cerveza, " +
                "dice el tipo. ",
                Category = "Borrachos"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Letrero en un bar: " +
                "Si bebe usted para olvidar" +
                "por favor pague por adelantado.",
                Category = "Borrachos"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Dos borrachos salen de un bar y uno dice: " +
                "-Joder, se me olvido mear. " +
                "-No pasa nada, yo te digo como.",
                Category = "Borrachos"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Un borracho orinaba apoyado en un árbol, " +
                "cuando aparece un carabinero y le dice: " +
                "¡Bonito, " +
                "noooo! " +
                "Y eso que no lo ha visto peinado...",
                Category = "Borrachos"
            });
            #endregion

            //Chistes de Futbol
            #region Futbol
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿En qué se parecen los Teletubbies a la Selección de futbol? " +
                "En que los dos salen al campo a hacer el pendejo.",
                Category = "Futbol"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Colmo de un futbolista... " +
                "meter un gol y en la repetición fallarlo.",
                Category = "Futbol"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Con todo el dinero que ganan los jugadores de fútbol, " +
                "¿por qué persiguen todos la misma pelota, en vez de comprarse una para cada uno?",
                Category = "Futbol"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Papá, papá... ¿me compras el balón de fútbol? " +
                "Bueno, " +
                "decídete: el balón o las muletas. ",
                Category = "Futbol"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Cómo se dice barrida de futbol en japonés? " +
                "Tukulito sacayama. ",
                Category = "Futbol"
            });

            #endregion

            //Chistes de mamá, mamá
            #region Mamá, mamá
            Listt.Add(new ListChistesModel
            {
                Chiste = "Papá, papá... ¿a ti te pegaba tu mamá? " +
                "No mijo, sólo la tuya. ",
                Category = "Mama"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Mamá, mamá... ¿la luz se come? " +
                "No, hijita. " +
                "Y ¿porqué papá anoche le dijo a la sirvienta: " +
                "Apaga la luz que te la vas a comer toda ? ",
                Category = "Mama"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Mamá, mamá... ¿La abuela es fluorescente? " +
                "No, hijo. " +
                "¡Uy!, entonces se está electrocutando.",
                Category = "Mama"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Mamá, mamá.... Jaimito me dijo marica. " +
                "¡Por Dios! ¿Y qué hiciste ? " +
                "¡Le pegué con mi bolsita!",
                Category = "Mama"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Mamá, mamá... sueño con ser millonario como un compañerito mío. " +
                "¿Tu compañerito es millonario ? " +
                "No, sueña... ",
                Category = "Mama"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Mamá, mamá... ¿por qué me dicen pie grande en el barrio? " +
                "No sé, nene, " +
                "pero... ¿ya guardaste los zapatos en el garage ? ",
                Category = "Mama"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Mamá, mamá... en la escuela me dicen mentiroso. " +
                "Cállate que ni vas a la escuela.",
                Category = "Mama"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Mamá mamá mamá mamá mamá " +
                "por que por que por que por que por que " +
                "me dicen me dicen me dicen me dicen me dicen " +
                "fenómeno fenomeno fenomeno fenomeno fenomeno. " +
                "No se hijo, pero toma tus 5 gorras y vamos a investigarlo.  ",
                Category = "Mama"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Mamá, mamá... papá tiene dos penes. " +
                "¿Cómo dos penes ? " +
                "Sí, uno pequeño para mear, " +
                "y uno grande y duro para limpiarle la boca a la mucama. ",
                Category = "Mama"
            });
            #endregion

            //Chistes de navidad
            #region Navidad
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿En que se parece un hombre a un árbol de Navidad? " +
                "En que las bolas sólo las traen de adorno.",
                Category = "Navidad"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿ En qué se parecen un cura a un árbol de navidad ? " +
                "En que las bolas las tienen de adorno.",
                Category = "Navidad"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Colmo de una solterona... " +
                "tener muchas navidades y ninguna nochebuena.",
                Category = "Navidad"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Qué es una esposa? " +
                "Mujer que pasa muchas Navidades, pero pocas Nochebuenas.",
                Category = "Navidad"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Por qué la Navidad es como un día en la oficina? " +
                "Tú haces todo el trabajo " +
                "y el gordo del traje se lleva todo el crédito. ",
                Category = "Navidad"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Sabes por qué la Navidad es blanca? " +
                "Por la venida de Santa Clós.",
                Category = "Navidad"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Por qué los mexicanos hacen tamales para Navidad? " +
                "" +
                "Para tener algo que desenvolver.",
                Category = "Navidad"
            });
            #endregion

            //Chistes de pepito
            #region Pepito
            Listt.Add(new ListChistesModel
            {
                Chiste = "Le dice Jaimito a sus amigos: " +
                "-Yo tengo 5 tías: Pata, Peta, Pita, Pota y..." +
                " una que no amanece en la casa.",
                Category = "Pepito"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "La miss a Pepito: " +
                "-A ver, si digo fui rica es pasado," +
                " pero si digo soy hermosa ¿que es? " +
                "- Exceso de imaginación profesora ",
                Category = "Pepito"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Le dice Pepito a sus amigos: " +
                "-Yo tengo 5 tías: Pata, Peta, Pita, Pota y..." +
                " una que no amanece en la casa.",
                Category = "Pepito"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Pepito, si en un bolsillo del pantalón tienes 1000 " +
                "y en el otro bolsillo 2000 ¿qué tienes en total? " +
                "Los pantalones de otro maestra",
                Category = "Pepito"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "-Maestra, ¿a qué edad se muere un burro? " +
                "-¿Por qué Pepito ? ¿Ya te sientes mal ? ",
                Category = "Pepito"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Pepito por qué golpeas a ese niño? " +
                "-Es que lambió mi comida. " +
                "-No, LAMIO. " +
                "-Que? También la mió? Ahora sí mato al cabrón!",
                Category = "Pepito"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Llega Pepito a la casa gritando: " +
                "Mami, ya no me esperes esta noche." +
                " ¿Cómo que no Jaimito? " +
                "¡No me esperes mami, por que ya llegué!",
                Category = "Pepito"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "La maestra de inglés se tropieza con Pepito " +
                "en el pasillo de la escuela y dice:" +
                " I'm Sorry. " +
                "Y pepito le contesta: I'm Pepito.",
                Category = "Pepito"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Pepito y su novia estaban en pleno agasajo cuando: " +
                "Pepito, ya me tengo que ir. " +
                "No te vayas ¡mejor vente!",
                Category = "Pepito"
            });
            #endregion

            //Chistes de policias
            #region Policias
            Listt.Add(new ListChistesModel
            {
                Chiste = "Un policía le pregunta a una puta, " +
                "¿Y que haría tu madre si te viese aquí? " +
                "Me mataría...esta es su esquina.",
                Category = "Policias"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿En qué se parece una mujer a un policía? " +
                "En que el policía tiene estrella, palo y es del estado;" +
                " a la mujer le metes el palo, ve las estrellas y cae en estado.",
                Category = "Policias"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Qué necesita un hombre para entrar a la policía? " +
                "Dos fotos y ser bruto. " +
                "¿Y una mujer ? " +
                "Dos fotos. ",
                Category = "Policias"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Mamá, mamá... los chicos en la escuela me dicen policía. " +
                "¿Quien te dice policia hijo ? " +
                "Momento, acá las preguntas las hago yo.",
                Category = "Policias"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Que le dice un pollito policía a otro pollito policía? " +
                "¡Necesitamos APOYO!",
                Category = "Policias"
            });
            #endregion

            //Chistes de suegra
            #region Suegra
            Listt.Add(new ListChistesModel
            {
                Chiste = "Suegra a la nuera: ¿Por qué ese bebé no se parece a su padre? " +
                "Bueno suegrita, " +
                "yo tengo una cu**, no una fotocopiadora!",
                Category = "Suegra"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Aviso clasificado: Busco suegra y perro. Recompensa por el perro.",
                Category = "Suegra"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "-¡Auxilio, socorro, se quema la casaaa! " +
                "-¡Shhh!Silencio mi amor, no hagas ruido que vas a despertar a tu madre.",
                Category = "Suegra"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Doctor al paciente: -Le quedan 7 dias de vida. " +
                "-¿Qué puedo hacer ? " +
                "-Vaya a vivir con su suegra y le parecerá una eternidad ",
                Category = "Suegra"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Por qué existen las suegras? " +
                "Porque el diablo no puede estar en todos lados",
                Category = "Suegra"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "A mi me gustaria que mi suegra fuera una estrella. " +
                "¿Sí ? ¿Para que te lleve a Holliwood ? " +
                "No, para que estuviese a 3000 años luz. ",
                Category = "Suegra"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "¿Cuál es la diferencia entre terrible y horrible? " +
                "La diferencia es que terrible es que venga una ola del mar " +
                "y se lleve a tu suegra a las profundidades, " +
                "y horrible, es que venga otra ola y te la traiga de vuelta.",
                Category = "Suegra"
            });
            Listt.Add(new ListChistesModel
            {
                Chiste = "Pepe, te veo preocupado. " +
                "Es que por poco atropello a mi suegra. " +
                "¿Te fallaron los frenos ? " +
                "No,el acelerador.",
                Category = "Suegra"
            });
            #endregion

            //Lo guardamos en la lista
            SingletonViewModel.GetInstance().GetList = Listt;
        }
        #endregion
    }
}

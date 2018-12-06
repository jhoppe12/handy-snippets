using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Web.Models;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;

namespace Capstone.Test.Integration
{
    [TestClass()]
    public class AllDALTestSetup
    {
        private TransactionScope tran;

        public string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=NPGeek;Integrated Security=True";
        //public AllDALTestSetup(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;

                conn.Open();

                cmd = new SqlCommand(@"

DELETE FROM survey_result;
DELETE FROM weather;
DELETE FROM park;

INSERT INTO park VALUES ('CVNP', 'Cuyahoga Valley National Park', 'Ohio', 32832, 696, 125, 0, 'Woodland', 2000, 2189849, 'Of all the paths you take in life, make sure a few of them are dirt.', 'John Muir', 'Though a short distance from the urban areas of Cleveland and Akron, Cuyahoga Valley National Park seems worlds away. The park is a refuge for native plants and wildlife, and provides routes of discovery for visitors. The winding Cuyahoga River gives way to deep forests, rolling hills, and open farmlands. Walk or ride the Towpath Trail to follow the historic route of the Ohio & Erie Canal', 0, 390)
INSERT INTO park VALUES ('ENP', 'Everglades National Park', 'Florida', 1508538, 0, 35, 0, 'Tropical', 1934, 1110901, 'There are no other Everglades in the world. They are, they have always been, one of the unique regions of the earth; remote, never wholly known. Nothing anywhere else is like them.', 'Marjory Stoneman Douglas', 'The Florida Everglades, located in southern Florida, is one of the largest wetlands in the world. Several hundred years ago, this wetlands was a major part of a 5,184,000 acre watershed that covered almost a third of the entire state of Florida. The Everglades consist of a shallow sheet of fresh water that rolls slowly over the lowlands and through billions of blades of sawgrass.', 8, 760)
INSERT INTO park VALUES('YNP', 'Yellowstone National Park', 'Wyoming', 2219791, 8000, 900, 1900, 'Temperate', 1872, 3394326, 'Yellowstone Park is no more representative of America than is Disneyland.', 'John Steinbeck', 'Yellowstone National Park is a protected area showcasing significant geological phenomena and processes. It is also a unique manifestation of geothermal forces, natural beauty, and wild ecosystems where rare and endangered species thrive. As the site of one of the few remaining intact large ecosystems in the northern temperate zone of earth, Yellowstone’s ecological communities provide unparalleled opportunities for conservation, study, and enjoyment of large-scale wildland ecosystem processes.', 15, 390)
INSERT INTO park VALUES('YNP2', 'Yosemite National Park', 'California', 747956, 5000, 800, 1720, 'Forest', 1890, 3882642, 'Yosemite Valley, to me, is always a sunrise, a glitter of green and golden wonder in a vast edifice of stone and space.', 'Ansel Adams', 'Yosemite National Park vividly illustrates the effects of glacial erosion of granitic bedrock, creating geologic features that are unique in the world. Repeated glaciations over millions of years have resulted in a concentration of distinctive landscape features, including soaring cliffs, domes, and free-falling waterfalls. There is exceptional glaciated topography, including the spectacular Yosemite Valley, a 914-meter deep, glacier-carved cleft having massive sheer granite walls. These geologic features provide a scenic backdrop for mountain meadows and giant sequoia groves, resulting in a diverse landscape of exceptional natural and scenic beauty.', 15, 420)
         
INSERT INTO weather VALUES('ENP',1,70,82,'partly cloudy');
INSERT INTO weather VALUES('ENP',2,70,81,'partly cloudy');
INSERT INTO weather VALUES('ENP',3,70,81,'partly cloudy');
INSERT INTO weather VALUES('ENP',4,71,82,'thunderstorms');
INSERT INTO weather VALUES('ENP',5,70,85,'sunny');
INSERT INTO weather VALUES('YNP',1,23,43,'cloudy');
INSERT INTO weather VALUES('YNP',2,26,47,'partly cloudy');
INSERT INTO weather VALUES('YNP',3,25,44,'sunny');
INSERT INTO weather VALUES('YNP',4,21,37,'snow');
INSERT INTO weather VALUES('YNP',5,16,36,'snow');
INSERT INTO weather VALUES('YNP2',1,34,51,'partly cloudy');
INSERT INTO weather VALUES('YNP2',2,25,39,'snow');
INSERT INTO weather VALUES('YNP2',3,29,40,'sunny');
INSERT INTO weather VALUES('YNP2',4,32,38,'snow');
INSERT INTO weather VALUES('YNP2',5,23,34,'snow');
INSERT INTO weather VALUES('CVNP',1,38,62,'rain');
INSERT INTO weather VALUES('CVNP',2,38,56,'partly cloudy');
INSERT INTO weather VALUES('CVNP',3,51,66,'partly cloudy');
INSERT INTO weather VALUES('CVNP',4,55,65,'rain');
INSERT INTO weather VALUES('CVNP',5,53,69,'thunderstorms')

INSERT INTO survey_result VALUES('ENP', 'bill@withers.org','KS', 'active')
INSERT INTO survey_result VALUES('ENP', 'john@denver.gov','CO', 'inactive')
INSERT INTO survey_result VALUES('YNP', 'climbIt@YourOwnRisk.io','TX', 'extremely active')
INSERT INTO survey_result VALUES('YNP', 'wetOne@OldFaithful.net','WY', 'active')
INSERT INTO survey_result VALUES('CVNP', 'shruteman@dunder-mifflin.org','PA', 'sedentary')
", conn);

                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }
    }
}

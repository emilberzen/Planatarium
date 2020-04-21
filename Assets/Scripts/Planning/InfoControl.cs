using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class InfoControl : MonoBehaviour
{
    public Image Image;
    public TextMeshProUGUI Header;
    public TextMeshProUGUI Location;
    public TextMeshProUGUI Country;
    public TextMeshProUGUI Body;



    [SerializeField]
    public Sprite[] TeleImage;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }


    }

    void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);

            if (hit.collider.gameObject.name == "Denmark")
            {
                Image.sprite = TeleImage[0];
                Header.text = "Brorfelde Observatorium";
                Country.text = "Denmark";
                Location.text = "60m";
                Body.text = "Brorfelde Observatory is an astronomical observatory located in Brorfelde near Holbaek, Denmark. It is home to the Brorfelde Schmidt Telescope and was run as a branch of the Copenhagen University Observatory until 1996. It still has telescopes that are used by University of Copenhagen students, but the staff that manned them moved to the Rockefeller Complex in Copenhagen.The 77 - centimetre Schmidt telescope from 1966 at Brorfelde Observatory was originally equipped with photographic film, and an engineer is here showing the film-box, which was then placed behind the locker at the center of the telescope(at the telescope's prime focus).";
            }
            else if (hit.collider.gameObject.name == "Chile Parnal")
            {

                Image.sprite = TeleImage[1];
                Header.text = "Paranal Observatory";
                Country.text = "Chile";
                Location.text = "2600m";
                Body.text = "Paranal Observatory is an astronomical observatory operated by the European Southern Observatory (ESO). It is located in the Atacama Desert of northern Chile on Cerro Paranal at 2,635 m (8,645 ft) altitude, 120 km (70 mi) south of Antofagasta. By total light-collecting area, it is the largest optical-infrared observatory in the Southern Hemisphere; worldwide, it is second to the Mauna Kea Observatory on Hawaii.";

            }
            else if (hit.collider.gameObject.name == "Chile La Silla")
            {
                Image.sprite = TeleImage[2];
                Header.text = "La Silla Observatory";
                Country.text = "Chile";
                Location.text = "2400m";
                Body.text = "La Silla Observatory is an astronomical observatory in Chile with three telescopes built and operated by the European Southern Observatory.The La Silla telescopes and instruments are located 150 km northeast of La Serena at the outskirts of the Chilean Atacama Desert, one of the driest and most remote areas of the world. Like other observatories in this geographical area, La Silla is located far from sources of light pollution and, like the Paranal Observatory, home to the Very Large Telescope, it has one of the darkest night skies on the Earth.";


            }
            else if (hit.collider.gameObject.name == "Chile Atacama")
            {
                Image.sprite = TeleImage[3];
                Country.text = "Chile";
                Location.text = "5460m";
                Header.text = "University Of Tokyo Atacama Observatory";
                Body.text = "The University of Tokyo Atacama Observatory (TAO) is an astronomical observatory located on the summit of Cerro Chajnantor within a lava dome in the Atacama Desert of northern Chile. \n In June 2009 the observatory became the highest permanent astronomical observatory in the world. The high altitude of the observatory is essential for its mission, for it is an infrared light observatory, and infrared light is absorbed by the water vapor in the atmosphere making it imperative that an infrared observatory is located in high altitude where the atmosphere is sparse.";
            }
            else if (hit.collider.gameObject.name == "South Africa")
            {

                Image.sprite = TeleImage[4];
                Country.text = "South Africa";
                Location.text = "1798m";
                Header.text = "South African Astronomical Observatory";
                Body.text = " South African Astronomical Observatory (SAAO) is the national centre for optical and infrared astronomy in South Africa. It was established in 1972. The observatory is run by the National Research Foundation of South Africa. The facility's function is to conduct research in astronomy and astrophysics. The primary telescopes are located in Sutherland, which is 370 kilometres (230 mi) from Observatory, Cape Town, where the headquarters is located.";


            }
            else if (hit.collider.gameObject.name == "Spain Astrofisico")
            {

                Header.text = "Roque De Los Muchachos Observatory";
                Body.text = "Roque de los Muchachos Observatory is an astronomical observatory located in the municipality of Garafía on the island of La Palma in the Canary Islands. The observatory was established in 1985, after 15 years of international work and cooperation of several countries with the Spanish island hosting many telescopes from Britain, The Netherlands, Spain, and other countries.";
                Country.text = "Spain";
                Location.text = "2396m";
                Image.sprite = TeleImage[5];

            }
            else if (hit.collider.gameObject.name == "Hawaii Mauna Kea")
            {
                Image.sprite = TeleImage[6];
                Country.text = "USA";
                Location.text = "4205m";
                Header.text = "Mauna Kea Observatories";
                Body.text = "The Mauna Kea Observatories are a number of independent astronomical research facilities and large telescope observatories that are located at the summit of Mauna Kea on the Big Island of Hawaiʻi, United States. The Astronomy Precinct was established in 1967 and is located on land protected by the Historical Preservation Act for its significance to Hawaiian culture. The presence and continued construction of telescopes is highly controversial due to Mauna Kea's centraility in native Hawaiian religion and culture, as well as for a variety of environmental reasons. The location is near ideal because of its dark skies from lack of light pollution, good astronomical seeing, low humidity, high elevation of 4,205 meters , position above most of the water vapor in the atmosphere, clean air, good weather and low latitude location.";
            }
            else if (hit.collider.gameObject.name == "South Pole Telescope")
            {
                Image.sprite = TeleImage[7];
                Country.text = "Antarctica";
                Location.text = "2800";
                Header.text = "South Pole Telescope";
                Body.text = "The South Pole Telescope is a 10-meter diameter telescope located at the Amundsen–Scott at the South Pole Station. The telescope is designed for observations in the microwave, millimeter-wave, and submillimeter-wave regions of the electromagnetic spectrum, with the particular design goal of measuring the faint, diffuse emission from the cosmic microwave background. The first major survey with the SPT–designed to find distant, massive, clusters of galaxies through their interaction with the CMB, with the goal of constraining the dark energy equation of state–was completed in October 2011. In early 2012, a new camera (SPTpol) was installed on the SPT with even greater sensitivity and the capability to measure the polarization of incoming light. This camera operated from 2012–2016 and was used to make unprecedentedly deep high-resolution maps of hundreds of square degrees of the Southern sky. ";

            }
            else if (hit.collider.gameObject.name == "Yerkes Observatory")
            {
                Image.sprite = TeleImage[8];
                Country.text = "USA";
                Location.text = "334m";
                Header.text = "Yerkes Observatory";
                Body.text = "Yerkes Observatory is an astronomical observatory in Williams Bay, Wisconsin owned by the University of Chicago Department of Astronomy and Astrophysics.The observatory, sometimes called the \"birthplace of modern astrophysics\", was founded in 1892 by astronomer George Ellery Hale and financed by businessman Charles T. Yerkes.  It represented a shift in the thinking about observatories, from their being mere housing for telescopes and observers, to the early-20th-century concept of observation equipment integrated with laboratory space for physics and chemistry analysis. The observatory ceased operations in 2018. The observatory houses a 102-cm diameter doublet lens refracting telescope, the largest ever successfully used for astronomy, and a collection of over 170,000 photographic plates. The observatory was a center for serious astronomical research for more than 100 years.";


            }
            else if (hit.collider.gameObject.name == "Kitt Peak Observatory")
            {
                Image.sprite = TeleImage[9];
                Country.text = "USA";
                Location.text = "2096m";
                Header.text = "Kitt Peak National Observatory";
                Body.text = "The Kitt Peak National Observatory is a United States astronomical observatory located on Kitt Peak of the Quinlan Mountains in the Arizona-Sonoran Desert on the Tohono O'odham Nation, 88 kilometers (55 mi) west-southwest of Tucson, Arizona. With over twenty optical and two radio telescopes, it is one of the largest gatherings of astronomical instruments in the northern hemisphere.";

            }
            else if (hit.collider.gameObject.name == "Arecibo Observatory")
            {
                Image.sprite = TeleImage[10];
                Country.text = "Purto Rico";
                Location.text = "498m"; 
                Header.text = "Arecibo Observatory";
                Body.text = "The Arecibo Observatory is a radio telescope in the municipality of Arecibo, Puerto Rico. The main collecting dish is 305 m (1,000 ft) in diameter, constructed inside the depression left by a karst sinkhole.[14] The dish surface is made of 38,778 perforated aluminum panels, each about 3 by 6 feet (1 by 2 m), supported by a mesh of steel cables. The ground beneath is accessible and supports shade-tolerant vegetation \nFor more than 50 years, from its completion in 1963 until July 2016 when the Five hundred meter Aperture Spherical Telescope(FAST) in China was completed, the Arecibo Observatory's 1,000-foot (305-meter) radio telescope was the world's largest single - aperture telescope.It is used in three major areas of research: radio astronomy, atmospheric science, and radar astronomy.Scientists who want to use the observatory submit proposals that are evaluated by an independent scientific board.";

            }
            else if (hit.collider.gameObject.name == "BTA-6 Russia")
            {

                Image.sprite = TeleImage[11];
                Country.text = "Russia";
                Location.text = "2070";
                Header.text = "BTA-6 Observatory";
                Body.text = "The BTA-6 is a 6-metre aperture optical telescope at the Special Astrophysical Observatory located in the Zelenchuksky District on the north side of the Caucasus Mountains in southern Russia. \n The BTA-6 achieved first light in late 1975, making it the largest telescope in the world until 1990, when it was surpassed by the partially constructed Keck 1. It pioneered the technique, now standard in large astronomical telescopes, of using an altazimuth mount with a computer-controlled derotator.";
            }
            else if (hit.collider.gameObject.name == "Sydney Observatory")
            {
                Image.sprite = TeleImage[12];
                Country.text = "Australia";
                Location.text = "3m"; 
                Header.text = "Sydney Observatory";
                Body.text = "The Sydney Observatory is a heritage-listed meteorological station, astronomical observatory, function venue, science museum, and education facility located on Observatory Hill at Upper Fort Street, in the inner city Sydney suburb of Millers Point in the City of Sydney local government area of New South Wales, Australia. It was designed by William Weaver (plans) and Alexander Dawson (supervision) and built from 1857 to 1859 by Charles Bingemann & Ebenezer Dewar. It is also known as The Sydney Observatory. It was added to the New South Wales State Heritage Register on 22 December 2000.";
            }

        }
    }
}

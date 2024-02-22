import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
    faYoutube,
    faFacebook,
    faXTwitter,
    faInstagram
  } from "@fortawesome/free-brands-svg-icons";


export default function SocialFollow() {
  return (
    <div>
      <a href="https://www.youtube.com/"
        className="youtube social me-2">
        <FontAwesomeIcon icon={faYoutube}/>
      </a>
      <a href="https://www.facebook.com/nasifrhman/"
        className="facebook social me-2">
        <FontAwesomeIcon icon={faFacebook} />
      </a>
      <a href="https://www.twitter.com/" className="twitter social me-2">
      <FontAwesomeIcon icon={faXTwitter} />
      </a>
      <a href="https://www.instagram.com/nasifrhman/"
        className="instagram social">
        <FontAwesomeIcon icon={faInstagram} />
      </a>
    </div>
  )
}

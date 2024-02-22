import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import SocialFollow from '../../components/SocialFollow';
export default function Footer() {
  return (
    <div>
        <footer className="text-center pt-4 bg-dark text-white">
            <Container>
                <Row>
                    <Col>
                        <h4>Contact Us</h4>
                        <p>Email: <a className="text-white text-decoration-none"
                         href="mailto:mdnasifurahman@gmail.com?body=My custom mail body">petz@gmail.com</a></p>
                        <p>Phone:
                        <a className="text-white text-decoration-none" href=" tel:01798552909">01798552909</a> </p>
                    </Col>
                    <Col className='mt-3'>
                        <h4>Social Follow</h4>
                        <SocialFollow/>
                    </Col>
                </Row>
            </Container>
        </footer>
    </div>
  )
}

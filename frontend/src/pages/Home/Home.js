import React from 'react';
import NavBar from '../../components/NavBar';
import HostelCard from '../../components/HostelCard';
import Gallery from '../../components/Gallery';
import 'bootstrap/dist/css/bootstrap.min.css';

import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Footer from '../Footer/Footer';
import Checkin from '../../components/checkin/Checkin';
import LandingText from '../../components/landingText/LandingText';
import './Home.css';
import Map from '../../components/map/Map';
const Home = () => {
    return (
        <div>
            <NavBar />
            <Container fluid className='me-0'>
                <Row style={{
                    backgroundImage: "linear-gradient(to right, rgba(59, 129, 128, .7), rgba(255, 255, 255, .5)), url('../../assets/group.jpg')",
                    backgroundSize: 'cover',
                    backgroundRepeat: 'no-repeat',
                    backgroundPosition: 'center',
                    height:'100vh'
                }}>
                    <div className="position-absolute top-0 start-0 w-100 h-100"></div>
                    <Col className="d-flex justify-content-center align-items-center ms-5 flex-column text-light" style={{ zIndex: 1, color: 'black' }}>
                        <LandingText />
                    </Col>
                    <Col className="d-flex justify-content-center align-items-center flex-column text-light" style={{ zIndex: 1 }}>
                        <Checkin />
                    </Col>
                </Row>
                <Row>
                    <h2 className="text-center my-5">Boarding Services</h2>
                    <Col><HostelCard /></Col>
                    <Col><HostelCard /></Col>
                    <Col><HostelCard /></Col>
                </Row>
                <Row>
                    <h2 className="text-center my-5">Gallery</h2>
                    <Col><Gallery /></Col>
                </Row>
            </Container>
            <div className='mt-5'><Map/></div>
            <div className='mt-1'><Footer /></div>
        </div>
    );
};

export default Home;

import React from 'react';
import { Col, Row } from 'react-bootstrap';

export default function Map() {
  return (
    <Row>
        <Col className='ms-5 p-5' style={{ textAlign: 'center' }}>
        <div>
            <iframe 
            src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3649.900722024339!2d90.42482601093131!3d23.822129085929657!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3755c711d13bbec7%3A0xc47f7c3e8e2263f2!2sAmerican%20International%20University%20-%20Bangladesh%20(AIUB)!5e0!3m2!1sen!2sbd!4v1708627388014!5m2!1sen!2sbd" 
            width="100%" 
            height="250" 
            style={{border:'0'}} 
            allowfullscreen="" 
            loading="lazy" 
            referrerpolicy="no-referrer-when-downgrade">
            </iframe>
        </div>
        </Col>
        <Col className="d-flex flex-column justify-content-center">
        <h4 className='ms-2'>Our Location</h4>
        <p className='ms-2 pt-1'> 408/1 (Old KA 66/1), Kuratoli, 
        <br/>Khilkhet,</p>
        </Col>
    </Row>
  );
}

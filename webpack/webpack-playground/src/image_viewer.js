// import small from '../assets/small.jpg';
import '../styles/image_viewer.css';

export default () => {
    const image = document.createElement('img');
    image.src = "http://lorempixel.com/400/440/";
    document.body.appendChild(image);
};
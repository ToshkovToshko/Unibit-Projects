let isAuthenticated = false;
let currentUser = null; 

// Масив с информация за филмите
const moviesData = [
    { 
        name: "Аватар", 
        photoUrl: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ8pTX23L1nlsDIPS2PwBQKCQ13CmoMg2RPUw&s", 
        description: "Бивш морски пехотинец е изпратен на Пандора, където е разкъсван между следването на заповедите си и защитата на новия свят, който е открил." 
    },
    { 
        name: "Начало", 
        photoUrl: "https://fantlab.ru/images/films/poster/big/9?r=1616393064", 
        description: "Коб е опитен крадец, най-добрият в опасното изкуство на извличане на информация чрез проникване в сънищата на хората." 
    },
    { 
        name: "Матрицата", 
        photoUrl: "https://www.ciela.com/media/catalog/product/cache/9a7ceae8a5abbd0253425b80f9ef99a5/9/6/96489.jpeg", 
        description: "Програмистът Томас Андерсън открива, че целият живот на Земята е сложна симулация, създадена от машини." 
    },
    { 
        name: "Интерстелар", 
        photoUrl: "https://www.zfilmi.com/sites/default/files/imagecache/ms_pp_thumb/Interstellar.jpg", 
        description: "Екип от изследователи пътува през червеева дупка в търсене на нов дом за човечеството." 
    },
];

//Масив с информация за потребителите 
const usersData = [];

// Функционалността за навигиране
function navigate(viewId) {

    document.querySelectorAll('.view').forEach(section => {
        section.style.display = 'none';
    });

    const targetView = document.getElementById(viewId);

    if (targetView) {
        targetView.style.display = 'block';
    }

    if (viewId === 'movies-list-view') {
        renderMoviesList();
    }
}

//Опресняване на навигационното меню
function updateNavBar(){
    const navBar = document.getElementById('navbar');
    navBar.innerHTML = ''; 


    const leftContent = document.createElement('a');
    leftContent.textContent = 'Филми';
    leftContent.href = '#';
    leftContent.addEventListener('click', () => navigate('movies-list-view'));
    navBar.appendChild(leftContent);

    const rightContent = document.createElement('div');
    rightContent.className = 'nav-right';

    if (isAuthenticated) {
        
        rightContent.innerHTML = `
            <span>Добре дошъл, ${currentUser.username}</span>
            <a href="#" id="list-link">Списъкс филми</a>
            <button id="logout-btn">Излез</button>
        `;
            
        rightContent.querySelector('#list-link').addEventListener('click', () => navigate('movies-list-view'));

        rightContent.querySelector('#logout-btn').addEventListener('click', handleLogout);

    } else {

        rightContent.innerHTML = `
            <a href="#" id="login-link">Влез</a>
            <a href="#" id="register-link">Регистрирай се</a>
        `;
        
        rightContent.querySelector('#login-link').addEventListener('click', () => navigate('login-view'));

        rightContent.querySelector('#register-link').addEventListener('click', () => navigate('register-view'));
    }

    navBar.appendChild(rightContent);
}

//Отговаря за излизане от профила
function handleLogout() {
    isAuthenticated = false;
    currentUser = null;
    updateNavBar();
    navigate('movies-list-view'); 
}

//Отговаря за формата за вход 
function handleLogin(event) {
    event.preventDefault(); 

    const usernameInput = document.getElementById('login-username');
    const passwordInput = document.getElementById('login-password');
    const errorMessage = document.getElementById('login-error-message');

    const username = usernameInput.value.trim();
    const password = passwordInput.value.trim();

    const userFound = usersData.find(user => 
        (user.username === username || user.email === username) && user.password === password
    );

    if (userFound) {

        isAuthenticated = true;
        currentUser = userFound;
        
        errorMessage.style.display = 'none';
        usernameInput.value = '';
        passwordInput.value = '';
        
        updateNavBar();
        navigate('movies-list-view');
        
    } else {
        errorMessage.textContent = 'Грешно потребителско име или парола.';
        errorMessage.style.display = 'block';
        passwordInput.value = ''; 
    }
}

//Отговаря за формата за регистрация 
function handleRegister(event) {
    event.preventDefault(); 

    const usernameInput = document.getElementById('register-username');
    const emailInput = document.getElementById('register-email');
    const passwordInput = document.getElementById('register-password');
    const successMessage = document.getElementById('register-success-message');

    const username = usernameInput.value.trim();
    const email = emailInput.value.trim();
    const password = passwordInput.value.trim();
    
    console.log(`Регистрация с: Username: ${username}, Email: ${email}, Password: ${password}`);
    successMessage.style.display = 'block';

    const existingUser = usersData.find(user => user.username === username || user.email === email);

    if (existingUser) {
        
        successMessage.style.color = 'red';
        successMessage.textContent = 'Потребител с това име или имейл вече е регистриран!';
        successMessage.style.display = 'block';

        setTimeout(() => {
            successMessage.style.display = 'none';
            successMessage.style.color = 'green'; 
        }, 3000);
        
        return;
    }

    const newUser = { username, email, password };
    usersData.push(newUser);

    successMessage.style.color = 'green';
    successMessage.textContent = 'Успешна регистрация! Моля, влезте в профила си.';
    successMessage.style.display = 'block';
    
    document.getElementById('register-form').reset();

    setTimeout(() => {
        successMessage.style.display = 'none';
        navigate('login-view');
    }, 2000); 
}

//Отговаря за списъка с филми
function renderMoviesList() {

    const container = document.getElementById('movies-container');

    container.innerHTML = ''; 

    const addMovieBtn = document.getElementById('add-movie-btn');
    
    if (addMovieBtn) {
        addMovieBtn.style.display = isAuthenticated ? 'block' : 'none';
    }

    moviesData.forEach(movie => {

        const movieCard = document.createElement('div');

        movieCard.className = 'movie-card';

        movieCard.innerHTML = `
            <h3>${movie.name}</h3>
            <img src="${movie.photoUrl}" alt="Постер на филма ${movie.name}" onerror="this.onerror=null;this.src='https://via.placeholder.com/200x300?text=No+Image';">
            <p class="movie-description" style="display:none;">${movie.description}</p>
            <button class="details-btn">Повече информация</button>
        `;
        
        movieCard.querySelector('.details-btn').addEventListener('click', (event) => {
            const descriptionElement = movieCard.querySelector('.movie-description');
            const button = event.target;
            
            if (descriptionElement.style.display === 'none') {
                descriptionElement.style.display = 'block';
                button.textContent = 'Скрий информацията';
            } else {
                descriptionElement.style.display = 'none';
                button.textContent = 'Повече информация';
            }
        });

        container.appendChild(movieCard);
    });
}

// Отговаря за добавянето на филми
function handleAddMovie(event) {
    event.preventDefault(); 

    if (!isAuthenticated) {
        alert('Трябва да сте влезли в профила си, за да добавяте филми!');
        navigate('login-view');
        return;
    }

    const nameInput = document.getElementById('movie-name');
    const urlInput = document.getElementById('movie-photo-url');
    const descriptionInput = document.getElementById('movie-description');
    const successMessage = document.getElementById('add-movie-success-message');

    const name = nameInput.value.trim();
    const photoUrl = urlInput.value.trim();
    const description = descriptionInput.value.trim();

    const newMovie = { 
        name, 
        photoUrl, 
        description 
    };

    moviesData.push(newMovie);
    console.log('Добавен нов филм:', newMovie);
    
    successMessage.style.display = 'block';

    document.getElementById('add-movie-form').reset();

    setTimeout(() => {
        successMessage.style.display = 'none';
        navigate('movies-list-view'); 
    }, 1500); 
}

//Отговаря за стартирането на приложението
document.addEventListener('DOMContentLoaded', () => {

    const loginForm = document.getElementById('login-form');
    if (loginForm) {
        loginForm.addEventListener('submit', handleLogin);
    }
    
    const registerForm = document.getElementById('register-form');
    if (registerForm) {
        registerForm.addEventListener('submit', handleRegister);
    }

    const addMovieForm = document.getElementById('add-movie-form');
    if (addMovieForm) {
        addMovieForm.addEventListener('submit', handleAddMovie);
    }

    const addMovieBtn = document.getElementById('add-movie-btn');
    if (addMovieBtn) {
        addMovieBtn.addEventListener('click', () => navigate('add-movie-view'));
    }

    updateNavBar(); 
    navigate('movies-list-view');
});
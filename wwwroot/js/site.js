// =========================================================
// TOEIC MASTER - SMOOTH SLIDER NAVIGATION (PAGE AWARE)
// =========================================================

document.addEventListener('DOMContentLoaded', () => {
    initSmoothSliderNav();
});

function initSmoothSliderNav() {
    const navLinks = document.querySelectorAll('#mainSlideNav .nav-link');
    const indicator = document.getElementById('navIndicator');
    const container = document.getElementById('slidebarContainer');

    if (!indicator || !navLinks.length || !container) return;

    // Helper: Move background pill directly and smoothly to a specific nav-link
    function moveIndicatorTo(element) {
        if (!element) return;
        
        const containerRect = container.getBoundingClientRect();
        const elementRect = element.getBoundingClientRect();
        
        const leftOffset = elementRect.left - containerRect.left;
        const elementWidth = elementRect.width;

        indicator.style.opacity = '1';
        indicator.style.transform = `translateX(${leftOffset}px)`;
        indicator.style.width = `${elementWidth}px`;
    }

    // Initialize indicator on the active link for the current page
    const initialActive = document.querySelector('#mainSlideNav .nav-link.active') || navLinks[0];
    if (initialActive) {
        setTimeout(() => moveIndicatorTo(initialActive), 60);
    }

    // Handle Window Resize (recalculate indicator width & position)
    window.addEventListener('resize', () => {
        const currentActive = document.querySelector('#mainSlideNav .nav-link.active') || navLinks[0];
        if (currentActive) {
            moveIndicatorTo(currentActive);
        }
    });
}

// Multi-dimensional Exam Filter (Status + Series)
let currentExamStatusFilter = 'all';
let currentExamSeriesFilter = 'all';

function filterExams(status) {
    currentExamStatusFilter = status;
    
    // Update status buttons active class
    const buttons = document.querySelectorAll('.exam-filter-pills .filter-btn');
    buttons.forEach(btn => {
        if (btn.getAttribute('data-filter') === status) {
            btn.classList.add('active');
        } else {
            btn.classList.remove('active');
        }
    });

    applyExamFilters();
}

function filterExamSeries(series) {
    currentExamSeriesFilter = series;
    
    // Update series buttons active class
    const buttons = document.querySelectorAll('.exam-series-pills .filter-btn');
    buttons.forEach(btn => {
        if (btn.getAttribute('data-series-filter') === series) {
            btn.classList.add('active');
        } else {
            btn.classList.remove('active');
        }
    });

    applyExamFilters();
}

function applyExamFilters() {
    const cards = document.querySelectorAll('.exam-card-item');
    cards.forEach(card => {
        const cardStatus = card.getAttribute('data-status');
        const cardSeries = (card.getAttribute('data-series') || '').toUpperCase();
        
        const matchStatus = (currentExamStatusFilter === 'all' || cardStatus === currentExamStatusFilter);
        const matchSeries = (currentExamSeriesFilter === 'all' || cardSeries === currentExamSeriesFilter.toUpperCase());

        if (matchStatus && matchSeries) {
            card.style.display = 'block';
            card.style.opacity = '0';
            setTimeout(() => {
                card.style.opacity = '1';
                card.style.transition = 'opacity 0.3s ease';
            }, 30);
        } else {
            card.style.display = 'none';
        }
    });
}

// Auth Modal Mode (Login vs Register)
let currentAuthMode = 'login';

function setAuthMode(mode) {
    currentAuthMode = mode;
    const modalTitle = document.getElementById('modalTitle');
    const modalSubtitle = document.getElementById('modalSubtitle');
    const registerGroup = document.getElementById('registerNameGroup');
    const loginOptions = document.getElementById('loginOptions');
    const submitBtn = document.getElementById('authSubmitBtn');
    const switchText = document.getElementById('authSwitchText');
    const switchLink = document.getElementById('authSwitchLink');

    if (mode === 'register') {
        modalTitle.innerText = 'Tạo tài khoản mới';
        modalSubtitle.innerText = 'Tham gia cộng đồng luyện thi TOEIC ngay hôm nay';
        registerGroup.style.display = 'block';
        loginOptions.style.display = 'none';
        submitBtn.innerText = 'Đăng ký tài khoản';
        switchText.innerText = 'Đã có tài khoản?';
        switchLink.innerText = 'Đăng nhập';
    } else {
        modalTitle.innerText = 'Đăng nhập tài khoản';
        modalSubtitle.innerText = 'Truy cập hàng trăm bộ đề và từ vựng TOEIC miễn phí';
        registerGroup.style.display = 'none';
        loginOptions.style.display = 'flex';
        submitBtn.innerText = 'Đăng nhập';
        switchText.innerText = 'Chưa có tài khoản?';
        switchLink.innerText = 'Đăng ký ngay';
    }
}

function toggleAuthMode() {
    setAuthMode(currentAuthMode === 'login' ? 'register' : 'login');
}

// Vocabulary Speech Synthesis
function speakWord(text) {
    if ('speechSynthesis' in window) {
        window.speechSynthesis.cancel();
        const utterance = new SpeechSynthesisUtterance(text);
        utterance.lang = 'en-US';
        utterance.rate = 0.9;
        window.speechSynthesis.speak(utterance);
    } else {
        alert('Trình duyệt không hỗ trợ phát âm tự động: ' + text);
    }
}

// Action: Start Exam
function startExam(id, title) {
    alert(`🎯 Chuẩn bị bước vào phòng thi!\n\nĐề thi: ${title}\nThời gian: 120 phút\n\nChúc bạn làm bài thật tốt!`);
}
// Filter Vocabulary Topics by status (all, completed, in-progress, not-started)
function filterVocabTopics(status) {
    const buttons = document.querySelectorAll('.vocab-filter-pills .filter-btn');
    buttons.forEach(btn => {
        if (btn.getAttribute('data-vocab-filter') === status) {
            btn.classList.add('active');
        } else {
            btn.classList.remove('active');
        }
    });

    const cards = document.querySelectorAll('.vocab-topic-item');
    cards.forEach(card => {
        const cardStatus = card.getAttribute('data-status');
        if (status === 'all' || cardStatus === status) {
            card.style.display = 'block';
            card.style.opacity = '0';
            setTimeout(() => {
                card.style.opacity = '1';
                card.style.transition = 'opacity 0.3s ease';
            }, 30);
        } else {
            card.style.display = 'none';
        }
    });
}